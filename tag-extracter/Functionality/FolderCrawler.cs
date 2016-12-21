using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tag_extracter.Functionality
{
    class FolderCrawler
    {
        List<AlbumFolder> workList = new List<AlbumFolder>();
        public List<AlbumFolder> crawlDirectories(string mainDir, bool main)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(mainDir))
                {
                    AlbumFolder dl = new AlbumFolder { fullPath = dir };
                    try
                    {
                        dl.numberOfFiles = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly).Count().ToString();
                        workList.Add(dl);
                    }
                    catch (UnauthorizedAccessException uaex)
                    {
                        dl.numberOfFiles = uaex.Message;
                    }
                    catch (Exception ex)
                    {
                        dl.numberOfFiles = ex.Message;
                    }

                    crawlDirectories(dir, false);
                }
            }
            catch (UnauthorizedAccessException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error reading directories with error: {0}", ex.Message), "Could not read directories",)
            }

            return workList;
        }
    }
}
