using DevExpress.Blazor;
using System.Reflection;

namespace WebApp.ForTrial.Components.Pages;

public partial class Home
{
    //readonly List<string> ALLOWED_FILE_TYPES = new List<string> { ".pdf" };
    //DxFileInput fileInput =  new();
    //byte[] DocumentContent { get; set; } = [];
    //protected override async Task OnInitializedAsync()
    //{
    //    Assembly assembly = Assembly.GetExecutingAssembly();
    //    using (Stream stream = assembly.GetManifestResourceStream("BlazorDemo.DataSources.Invoice.pdf"))
    //    using (var binaryReader = new BinaryReader(stream))
    //        DocumentContent = binaryReader.ReadBytes((int)stream.Length);
    //}
    //protected async Task OnFilesUploading(FilesUploadingEventArgs args)
    //{
    //    using (MemoryStream stream = new MemoryStream())
    //    {
    //        IFileInputSelectedFile file = args.Files[0];
    //        await file.OpenReadStream(file.Size).CopyToAsync(stream);
    //        DocumentContent = stream.ToArray();
    //        await InvokeAsync(StateHasChanged);
    //    }
    //}

}
