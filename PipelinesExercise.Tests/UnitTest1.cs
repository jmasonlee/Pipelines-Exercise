using NUnit.Framework;
using PipelinesExercise;
using ApprovalTests;
using ApprovalTests.Reporters;


namespace Tests
{
    public class Tests
    {
        [Test]
        [UseReporter(typeof(DotReporter))]
        public void Test_StartHere()
        {
            // Set up Pipeline objects
            // `PipelineApprovals.Verify()`
            // Send input through pipeline
            // Original code
            Implementation.LogOrError = Implementation.Log;

            var inputNamePipe = new InputPipe<ZipCode>("zipcode");
            PipelineApprovals.Verify(inputNamePipe);
            SimpleCalls.FindBestSandwich(new ZipCode("90210"));
        }

        [Test]
        [Ignore("Turn on when ready.")]
        public void Test2_EasyWay()
        {
            new DoEverythingTheEasyWay().MakeAllTheViewModels("filename", "username", "password");
        }

        [Test]
        [Ignore("Turn on when ready.")]
        public void Test3_HardWay()
        {
            new DoEverythingTheHardWay().MakeAllTheViewModels("filename", "username", "password");
        }
    }
}