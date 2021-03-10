using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RefactoringsTest2021
{
    public class InlineMethod
    {
        private async void InlineMethod1(object sender)
        {
            HttpClient httpClient = new();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
            using (FileStream sourceStream = new("temp.html", FileMode.Create,
                FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);

                // Inline here
                WriteAsync2(encodedText, 0, encodedText.Length, sourceStream);

                // Inline here
                await WriteAsync1(encodedText, 0, encodedText.Length, sourceStream).ConfigureAwait(false);
            }
        }

        static void InlineMethod2()
        {
            // Inline here
            var i = Foo(true);
        }

        static int Foo(bool x)
        {
            if (x)
                return 1;
            return 2;
        }

        public Task WriteAsync1(byte[] buffer, int offset, int count, FileStream sourceStream)
        {
            return sourceStream.WriteAsync(buffer, offset, count, CancellationToken.None);
        }

        public async void WriteAsync2(byte[] buffer, int offset, int count, FileStream sourceStream)
        {
            await sourceStream.WriteAsync(buffer, offset, count, CancellationToken.None).ConfigureAwait(false);
        }
    }
}