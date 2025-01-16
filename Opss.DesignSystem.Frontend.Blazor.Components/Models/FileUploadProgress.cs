using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models
{
    public class FileUploadProgress
    {
        public FileUploadProgress(IBrowserFile file, Action callback)
        {
            File = file;
            Callback = callback;
            FileName = file.Name;
        }

        public IBrowserFile File { get; set; }
        private Action Callback { get; }
        public string FileName { get; set; }
        public int ProgressPercent { get; set; } = 0;

        public void UpdateProgress(int progress)
        {
            ProgressPercent = progress;
            Callback();
        }
    }
}
