using System;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HyperDAT
{
    public partial class HyperDAT : Form
    {
        private string DatXmlPath = String.Empty;

        public HyperDAT()
        {
            InitializeComponent();
        }

        #region Folder selection

        private void buttonSelectXML_Click(object sender, EventArgs e)
        {

            if ((DialogResult)openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                textBoxXMLPath.Text = openFileDialogXML.FileName;
            }
        }

        private void buttonAddDAT_Click(object sender, EventArgs e)
        {
            if ((DialogResult)openFileDialogDAT.ShowDialog() == DialogResult.OK)
            {
                if (!listBoxDATPaths.Items.Contains(openFileDialogDAT.FileNames.Length >0))
                {
                    listBoxDATPaths.Items.AddRange(openFileDialogDAT.FileNames);
                }
            }
        }

        private void buttonRemoveDAT_Click(object sender, EventArgs e)
        {
            listBoxDATPaths.Items.Remove(listBoxDATPaths.SelectedItem);
        }

        private void buttonSelectWorkingFolder_Click(object sender, EventArgs e)
        {
            if ((DialogResult)folderBrowserDialogWorking.ShowDialog() == DialogResult.OK)
            {
                textBoxWorkDir.Text = folderBrowserDialogWorking.SelectedPath;
            }
        }

        private void buttonSelectNameMatchesXml_Click(object sender, EventArgs e)
        {

            if ((DialogResult)openFileDialogNameMatchesXml.ShowDialog() == DialogResult.OK)
            {
                textBoxNameMatchesXml.Text = openFileDialogNameMatchesXml.FileName;
            }
        }

        private void buttonMediaFolder_Click(object sender, EventArgs e)
        {
            if ((DialogResult)folderBrowserDialogMedia.ShowDialog() == DialogResult.OK)
            {
                textBoxMediaFolder.Text = folderBrowserDialogMedia.SelectedPath;
            }
        }


        #region Drag'n'drop
        private void listBoxDATPaths_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBoxDATPaths.Items.Add(s[i]);
        }

        private void listBoxDATPaths_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }


        private void textBoxXMLPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (s.Length > 0)
                textBoxXMLPath.Text = s[0];
        }

        private void textBoxXMLPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }


        private void textBoxWorkDir_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (s.Length > 0)
                textBoxWorkDir.Text = s[0];
        }

        private void textBoxWorkDir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBoxNameMatchesXml_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (s.Length > 0)
                textBoxNameMatchesXml.Text = s[0];
        }

        private void textBoxNameMatchesXml_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBoxMediaFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (s.Length > 0)
                textBoxMediaFolder.Text = s[0];

        }

        private void textBoxMediaFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }


        #endregion

        #endregion

        #region Matching Xml<>Dat

        private void buttonCreateFakeFiles_Click(object sender, EventArgs e)
        {

            if (!File.Exists(textBoxXMLPath.Text) || (listBoxDATPaths.Items.Count == 0))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //--- Fatmatch directories creation
                if (Directory.Exists(Path.Combine(textBoxWorkDir.Text, "fatmatch_roms")))
                    Directory.Delete(Path.Combine(textBoxWorkDir.Text, "fatmatch_roms"), true);

                if (Directory.Exists(Path.Combine(textBoxWorkDir.Text, "fatmatch_images")))
                    Directory.Delete(Path.Combine(textBoxWorkDir.Text, "fatmatch_images"), true);

                Directory.CreateDirectory(Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms"));
                Directory.CreateDirectory(Path.Combine(textBoxWorkDir.Text, @"fatmatch_images"));

                //------------------ Hyperlist
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(textBoxXMLPath.Text);

                //* Get elements.
                XmlNodeList xmlgames = xmlDoc.GetElementsByTagName("game");

                foreach (XmlNode game in xmlgames)
                {
                    String xmlgame = game.Attributes["name"].InnerText;

                    using (File.Create(Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + xmlgame + ".zip")) ;
                }

                //----------------- Dat
                CreateDatXml();
                XmlDocument datDoc = new XmlDocument();
                datDoc.Load(DatXmlPath);

                //* Get elements.
                XmlNodeList datgames = datDoc.GetElementsByTagName("game");

                foreach (XmlNode game in datgames)
                {
                    String datgame = game.Attributes["name"].InnerText;

                    using (File.Create(Path.Combine(textBoxWorkDir.Text, @"fatmatch_images\") + datgame + ".jpg")) ;
                }

                DropTempFiles();

                MessageBox.Show("Fatmatch folders are located here:\n\n" + Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + "\n" + Path.Combine(textBoxWorkDir.Text, @"fatmatch_images\"), "File creation done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Opening Fatmatch
        /// </summary>
        private void buttonLaunchFatmatch_Click(object sender, EventArgs e)
        {
            Process proc = Process.Start(new ProcessStartInfo(@"lib\FatMatch.exe"));
            proc.WaitForExit();


            // When finished, if a match file was generated, we append to existing (for multi-pass mgmt)
            string FatmatchOutput = Path.Combine(textBoxWorkDir.Text, @"fatmatch_images\FM_Renamed\") + "_ReverseRename.bat";
            string Fatmatched     = Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + "_Fatmatched.txt";

            if (File.Exists(FatmatchOutput))
            {
                File.AppendAllLines(Fatmatched, File.ReadAllLines(FatmatchOutput));
                File.Delete(FatmatchOutput);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildMatchFile_Click(object sender, EventArgs e)
        {
            HashSet<string> xmlnames = new HashSet<string>();
            HashSet<string> datnames = new HashSet<string>();
            HashSet<string> datdups  = new HashSet<string>();

            string FatmatchOUtput = Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + "_Fatmatched.txt";

            if (File.Exists(FatmatchOUtput))
            {
                string NameMatchesXmlPath = textBoxWorkDir.Text + @"\" + Path.GetFileNameWithoutExtension(textBoxXMLPath.Text) + " (HyperDAT Matches v" + DateTime.Now.ToString("yyyy-MM-dd") + ").xml";
                string NameErrorsXmlPath = textBoxWorkDir.Text + @"\" + Path.GetFileNameWithoutExtension(textBoxXMLPath.Text) + " (HyperDAT Errors v" + DateTime.Now.ToString("yyyy-MM-dd") + ").xml";


                //-------------- Matches
                XmlTextWriter w = new XmlTextWriter(NameMatchesXmlPath, null);
                w.Formatting = Formatting.Indented;

                w.WriteStartDocument();
                w.WriteStartElement("matches");

                w.WriteStartElement("header");
                w.WriteStartElement("name");
                w.WriteString(Path.GetFileNameWithoutExtension(textBoxXMLPath.Text) + " (HyperDAT Matches)");
                w.WriteEndElement();
                w.WriteStartElement("version");
                w.WriteString(DateTime.Now.ToString("yyyy-MM-dd"));
                w.WriteEndElement();
                w.WriteStartElement("author");
                w.WriteString("HyperDAT - (c) 2011 Omar Benguerah");
                w.WriteEndElement();
                w.WriteEndElement();

                using (TextReader r = File.OpenText(FatmatchOUtput))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        if (line.StartsWith("REN "))
                        {
                            int spliterPos = line.IndexOf(@""" """, 5);
                            string xmlName = line.Substring(5, spliterPos - 9);
                            string datName = line.Substring(spliterPos + 3, line.Length - spliterPos - 8);

                            //For missing checks
                            xmlnames.Add(xmlName);

                            //Duplicate name checking...
                            if (!datnames.Add(datName))
                            {
                                DialogResult res = MessageBox.Show(String.Format("\"{0}\"\n\nwas already matched. \n\nDo you want the continue ?", datName), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (res == DialogResult.No)
                                    break;
                                else
                                    datdups.Add(datName);
                            }

                            w.WriteStartElement("game");
                            w.WriteAttributeString("xmlname", xmlName);
                            w.WriteAttributeString("datname", datName);
                            w.WriteEndElement();

                            //We move the roms file, for a second pass matching ...
                            if (!Directory.Exists(Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\matched\")))
                                Directory.CreateDirectory(Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\matched\"));

                            if (File.Exists(Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + xmlName + ".zip"))
                            {
                                File.Move(
                                    Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\") + xmlName + ".zip",
                                    Path.Combine(textBoxWorkDir.Text, @"fatmatch_roms\matched\") + xmlName + ".zip");
                            }

                        }
                    }
                }

                w.WriteEndElement();
                w.WriteEndDocument();
                w.Close();

                //-- Set Matches path
                textBoxNameMatchesXml.Text = NameMatchesXmlPath;


                //-------------- Errors
                w = new XmlTextWriter(NameErrorsXmlPath, null);
                w.Formatting = Formatting.Indented;

                w.WriteStartDocument();
                w.WriteStartElement("errors");

                w.WriteStartElement("header");
                w.WriteStartElement("name");
                w.WriteString(Path.GetFileNameWithoutExtension(textBoxXMLPath.Text) + " (HyperDAT Errors)");
                w.WriteEndElement();
                w.WriteStartElement("version");
                w.WriteString(DateTime.Now.ToString("yyyy-mm-dd"));
                w.WriteEndElement();
                w.WriteStartElement("author");
                w.WriteString("HyperDAT - (c) 2011 Omar Benguerah");
                w.WriteEndElement();
                w.WriteEndElement();

                //-- Missing
                w.WriteStartElement("missing");

                XmlDocument xmlDoc = new XmlDocument(); 
                xmlDoc.Load(textBoxXMLPath.Text); 

                //-- Get elements
                XmlNodeList xmlgames = xmlDoc.GetElementsByTagName("game");

                foreach (XmlNode game in xmlgames)
                {
                    String xmlgame = game.Attributes["name"].InnerText;

                    if (!xmlnames.Contains(xmlgame))
                    {
                        w.WriteStartElement("game");
                        w.WriteAttributeString("xmlname", xmlgame);
                        w.WriteEndElement();
                    }
                }

                w.WriteEndElement();


                //-- Duplicates
                w.WriteStartElement("duplicates");

                foreach (string dupdat in datdups)
                {
                    w.WriteStartElement("game");
                    w.WriteAttributeString("datname", dupdat);
                    w.WriteEndElement();
                }

                w.WriteEndElement();

                w.WriteEndElement();
                w.WriteEndDocument();
                w.Close();

                MessageBox.Show("Matching finiched");
            }
            else
            {
                MessageBox.Show(String.Format("{0} Not found", FatmatchOUtput), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #endregion

        #region Merged DAT creator


        private void buttonMergeDAT_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxNameMatchesXml.Text) || !File.Exists(textBoxXMLPath.Text) || (listBoxDATPaths.Items.Count == 0))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
            else
            {
                //--------------------------------- Chargement des 3 XML en mémoire et création de la nouvelle liste tampon
                Dictionary<string, XmlNode> xmlGames = new Dictionary<string, XmlNode>();
                Dictionary<string, XmlNode> datGames = new Dictionary<string, XmlNode>();
                Dictionary<string, XmlNode> matchGames = new Dictionary<string, XmlNode>();
                Dictionary<string, XmlNode> mergedGames = new Dictionary<string, XmlNode>();

                //----- Load XMl orginal
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(textBoxXMLPath.Text);

                XmlNodeList xmlNodes = xmlDoc.GetElementsByTagName("game");

                foreach (XmlNode game in xmlNodes)
                {
                    xmlGames.Add(game.Attributes["name"].InnerText, game);
                }

                //----- Load Dat (xml)
                CreateDatXml();
                XmlDocument datDoc = new XmlDocument();
                datDoc.Load(DatXmlPath);

                XmlNodeList datNodes = datDoc.GetElementsByTagName("game");

                foreach (XmlNode game in datNodes)
                {
                    datGames.Add(game.Attributes["name"].InnerText, game);
                }


                //----- Load XMl orginal
                XmlDocument matchDoc = new XmlDocument();
                matchDoc.Load(textBoxNameMatchesXml.Text);

                XmlNodeList matchNodes = matchDoc.GetElementsByTagName("game");

                foreach (XmlNode game in matchNodes)
                {
                    matchGames.Add(game.Attributes["xmlname"].InnerText, game);
                }

      
                //--------------------------------- Balayage de la liste source
                foreach (string xmlGameName in xmlGames.Keys)
                {
                    string datGameName = String.Empty;

                    //---Existe elle dans le match table
                    if (matchGames.ContainsKey(xmlGameName))
                    {
                        datGameName = matchGames[xmlGameName].Attributes["datname"].InnerText;

                        //Recup du noeud du DAT correspondant
                        XmlNode datGame = null;
                       
                        if (datGames.ContainsKey(datGameName))
                        {
                            datGame = datGames[datGameName];

                            //Renommage et nettoyage
                            datGame.Attributes["name"].InnerText = xmlGameName;

                            XmlNode cueRom = null;

                            foreach (XmlNode rom in datGame.ChildNodes)
                            {
                                //element de type rom
                                if (rom.Name == "rom")
                                {
                                    string romOldName = rom.Attributes["name"].InnerText;

                                    string romext = romOldName.Substring(romOldName.Length - 3);

                                    //--- On renome si cue et mode uniquement cue ou alors pas mode sans cue
                                    if (((romext == "cue") && (radioButtonCueRename.Checked)) || ((romext != "cue") && radioButtonCueDelete.Checked))
                                        rom.Attributes["name"].InnerText = rom.Attributes["name"].InnerText.Replace(datGameName + ".", xmlGameName + ".");
                                    else if (romext == "cue")  //-- si reste le cue 
                                        cueRom = rom;
                                }
                                else if (rom.Name == "description")
                                {
                                    rom.InnerText = xmlGameName;
                                }
                            }

                            //Virer Cue
                            if (cueRom != null)
                                datGame.RemoveChild(cueRom);


                            //Ajout à la liste tampon finale
                            mergedGames.Add(xmlGameName, datGame);
                        }
                        else
                        {
                            mergedGames.Add(xmlGameName, GetUndefinedSet(xmlDoc, xmlGames[xmlGameName]));
                        }
                    }
                    else
                    {
                        mergedGames.Add(xmlGameName, GetUndefinedSet(xmlDoc, xmlGames[xmlGameName]));
                    }
                }


                //-----------Header

                string MergedName = String.Empty;
                string MergedDescription = String.Empty;
                string MergedVersion = String.Empty;
                string MergedAuthor = String.Empty;

                //--- Name
                XmlNodeList nodes1;
                XmlNodeList nodes2;
                XmlNodeList nodes3;

                nodes1 = xmlDoc.GetElementsByTagName("listname");
                if (nodes1.Count > 0)
                {
                    MergedName = nodes1[0].InnerText;
                    MergedDescription = String.Format("{0} (HyperDAT)", MergedName);
                }

                //--- Description
                if (nodes1.Count > 0)
                {
                   
                }

                //--- Version
                nodes1 = xmlDoc.GetElementsByTagName("listversion");
                nodes2 = datDoc.GetElementsByTagName("version");
                nodes3 = datDoc.GetElementsByTagName("author");

                if ((nodes1.Count > 0) && (nodes2.Count > 0) && (nodes3.Count > 0))
                {
                    MergedVersion = String.Format("Hyperlist {0} + {2} {1}", nodes1[0].InnerText, nodes2[0].InnerText, nodes3[0].InnerText);
                }

                //--- Author
                MergedAuthor = "HyperDAT - (c) 2011 Omar Benguerah";

                //--------------------------------- Formatage final et sauvegarde
                XmlTextWriter w = new XmlTextWriter(textBoxWorkDir.Text + @"\" + MergedName + " (HyperDAT).xml", null);
                w.Formatting = Formatting.Indented;
                w.WriteStartDocument();
                w.WriteStartElement("datafile");
                
                //write xml
                w.WriteStartElement("header");

                w.WriteStartElement("name");
                w.WriteValue(MergedName);
                w.WriteEndElement();

                w.WriteStartElement("description");
                w.WriteValue(MergedDescription);
                w.WriteEndElement();

                w.WriteStartElement("version");
                w.WriteValue(MergedVersion);
                w.WriteEndElement();

                w.WriteStartElement("author");
                w.WriteValue(MergedAuthor);
                w.WriteEndElement();

                w.WriteEndElement();


                //-----------Games
                foreach (XmlNode game in mergedGames.Values)
                {
                    game.WriteTo(w);
                }
                //-----------Fin
                w.WriteEndElement();
                w.Close();

                //Conversion DAT (old format)
                string cmdline = String.Format(@"-f li -k -o ""{0}\{1} (HyperDAT).dat"" ""{0}\{1} (HyperDAT).xml""", textBoxWorkDir.Text, MergedName);

                ProcessStartInfo psi = new ProcessStartInfo(@"lib\datutil.exe", cmdline);
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process proc = Process.Start(psi);
                proc.WaitForExit();

                File.Delete(textBoxWorkDir.Text + @"\" + MergedName + " (HyperDAT).xml");

                DropTempFiles();

                MessageBox.Show("HyperDAT created : " + textBoxWorkDir.Text + @"\" + MergedName + " (HyperDAT).dat" ,"Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Media management

        private void buttonRenameMedia_Click(object sender, EventArgs e)
        {
            //Chargement du xml de matching
            if (!File.Exists(textBoxNameMatchesXml.Text) || !Directory.Exists(textBoxMediaFolder.Text))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //----- Load matching
                XmlDocument matchDoc = new XmlDocument();
                matchDoc.Load(textBoxNameMatchesXml.Text);

                XmlNodeList matchNodes = matchDoc.GetElementsByTagName("game");


                string backupscript = textBoxMediaFolder.Text + @"\_renamebkp.txt";
                int countrenamed = 0;
                
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(backupscript))
                {
                    foreach (XmlNode game in matchNodes)
                    {
                        string xmlname = game.Attributes["xmlname"].InnerText;
                        string datname = game.Attributes["datname"].InnerText;


                        string[] MediaFiles = Directory.GetFiles(textBoxMediaFolder.Text, datname + ".*");

                        if (MediaFiles.Length == 1)
                        {
                            string mediafromname = MediaFiles[0];
                            string mediatoname = textBoxMediaFolder.Text + @"\" + xmlname + Path.GetExtension(MediaFiles[0]);


                            sw.WriteLine(String.Format(@"ren ""{1}"" ""{0}"" ",Path.GetFileName(mediafromname),Path.GetFileName(mediatoname)));
                            File.Move(mediafromname, mediatoname);

                            countrenamed++;
                        }
                    }
                }


                if ((!checkBoxMediaBackup.Checked) && File.Exists(backupscript))
                    File.Delete(backupscript);

                MessageBox.Show(countrenamed + " Files renamed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonListMediaErrors_Click(object sender, EventArgs e)
        {

            //Chargement du xml 
            if (!File.Exists(textBoxXMLPath.Text) || !Directory.Exists(textBoxMediaFolder.Text))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HashSet<string> xmlnames = new HashSet<string>();

                //----- Load matching
                XmlDocument matchDoc = new XmlDocument();
                matchDoc.Load(textBoxXMLPath.Text);

                XmlNodeList matchNodes = matchDoc.GetElementsByTagName("game");


                string missinglog = textBoxMediaFolder.Text + @"\_missing.txt";
                int nbmissing = 0;

                //---- Missing
                using (StreamWriter sw = File.CreateText(missinglog))
                {
                    foreach (XmlNode game in matchNodes)
                    {
                        string xmlname = game.Attributes["name"].InnerText;
                        xmlnames.Add(xmlname);

                        string[] MediaFiles = Directory.GetFiles(textBoxMediaFolder.Text, xmlname + ".*");

                        if (MediaFiles.Length == 0)
                        {
                            sw.WriteLine(xmlname);
                            nbmissing++;
                        }
                    }
                 }


                //---- Unknown
                string unknownlog = textBoxMediaFolder.Text + @"\_unknown.txt";
                int nbunknown = 0;

                using (StreamWriter sw = File.CreateText(unknownlog))
                {
                    string[] MediaFiles = Directory.GetFiles(textBoxMediaFolder.Text, "*.*");

                    foreach (string media in MediaFiles)
                    {
                        if ((!xmlnames.Contains(Path.GetFileNameWithoutExtension(media))) && !(Path.GetExtension(media) == ".db") && !((Path.GetExtension(media) == ".txt") && (Path.GetFileName(media).StartsWith("_"))))
                        {
                            if (checkBoxMoveUnknownMedia.Checked)
                            {
                                if (!Directory.Exists(Path.Combine(textBoxMediaFolder.Text, "_unknown")))
                                    Directory.CreateDirectory(Path.Combine(textBoxMediaFolder.Text, "_unknown"));

                                File.Move(media, Path.Combine(textBoxMediaFolder.Text, "_unknown") + @"\" + Path.GetFileName(media));
                            }
                            else
                            {
                                sw.WriteLine(Path.GetFileName(media));
                            }
                            nbunknown++;
                        }
                    }
                }

                if ((checkBoxMoveUnknownMedia.Checked) && File.Exists(unknownlog))
                    File.Delete(unknownlog);

                 MessageBox.Show(nbmissing + " Files missing\n" + nbunknown + " Files unknown", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        
        #region Helpers


        /// <summary>
        /// Local merge XML version of DAT
        /// </summary>
        private void CreateDatXml()
        {
            string cmdline = String.Empty;

            foreach (string DatPath in listBoxDATPaths.Items)
            {
                //--- Conversion individuelle des fichiers DAT en XML
                cmdline = String.Format(@"-f gx -k -o ""{1}\{2}.xml"" ""{0}""", DatPath, textBoxWorkDir.Text, Path.GetFileNameWithoutExtension(DatPath));

                ProcessStartInfo psi = new ProcessStartInfo(@"lib\datutil.exe", cmdline);
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process proc = Process.Start(psi);
                proc.WaitForExit();
            }

            //--- Merge des fichiers
            DatXmlPath = textBoxWorkDir.Text + @"\" + Path.GetFileNameWithoutExtension(textBoxXMLPath.Text) + " (HyperDAT DATS).xml";

            XmlTextWriter w = new XmlTextWriter(DatXmlPath, null);
            w.Formatting = Formatting.Indented;

            w.WriteStartDocument();
            w.WriteStartElement("datafile");

            XmlNode header = null;
            int nbgames = 0;

            foreach (string DatPath in listBoxDATPaths.Items)
            {
                string xmlPath = textBoxWorkDir.Text + @"\" + Path.GetFileNameWithoutExtension(DatPath) + ".xml";

                XmlDocument datxmlDoc = new XmlDocument();
                datxmlDoc.Load(xmlPath);

                XmlNodeList datgames = datxmlDoc.GetElementsByTagName("game");
                XmlNodeList headers = datxmlDoc.GetElementsByTagName("header");

                if ((headers.Count > 0) && (datgames.Count > nbgames))
                {
                    header = headers[0];
                    nbgames = datgames.Count;
                }

                foreach (XmlNode game in datgames)
                {
                    game.WriteTo(w);
                }

                File.Delete(xmlPath);
            }

            if (header != null)
                header.WriteTo(w);

            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
        }

        private void DropTempFiles()
        {
            File.Delete(DatXmlPath);
        }

        private XmlNode GetUndefinedSet(XmlDocument xmlDoc, XmlNode xmlGame)
        {
            string xmlGameName = xmlGame.Attributes["name"].InnerText;
            xmlGame.RemoveAll();
            XmlElement el = (XmlElement)xmlGame;
            el.SetAttribute("name", xmlGameName);

            //-- Dumb rom
            XmlElement rom = xmlDoc.CreateElement("rom");

            rom.SetAttribute("name", "Undefined set");
            rom.SetAttribute("size", "0");
            rom.SetAttribute("crc", "ffffffff");
            el.AppendChild(rom);

            return xmlGame;
        }

        #endregion
        
    }
}
