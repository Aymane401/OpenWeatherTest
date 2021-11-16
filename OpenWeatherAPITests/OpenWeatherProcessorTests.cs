using System;
using System.Threading.Tasks;
using Xunit;
using OpenWeatherAPI;


namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {

            [Fact]
            public async Task GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
            {

                OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;


                await Assert.ThrowsAsync<ArgumentException>(owp.GetOneCallAsync);
            }

        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {


            OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;



            await Assert.ThrowsAsync<ArgumentException>(owp.GetCurrentWeatherAsync);
        }

    }
}
