using Cocona;

using TextCopy;

CoconaApp.Run(([Argument] string guid) =>
{
    var result = Guid.Parse(guid).ToString();
    Console.WriteLine(result);
    ClipboardService.SetText(result);
});
