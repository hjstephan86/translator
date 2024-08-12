namespace translator
{
    public class TestHelper
    {

        [Fact]
        public void DeleteWordsToDeleteEmptySpaceLeftTest()
        {
            String transcript =         "Hand, die die Hand mit der Hand nahm.";
            String expectedTranscript = "Hand, die die mit der Hand nahm.";

            char[] delims = { '.', ',', '?', '!', ' ' };
            string[] wordsFromTranscript = transcript.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            LinkedList<WordToDelete> wordsToDelete = new LinkedList<WordToDelete>();
            WordToDelete wordToDelete = new WordToDelete(transcript, "Hand", 3, wordsFromTranscript);
            wordsToDelete.AddFirst(wordToDelete);

            transcript = Helper.DeleteWordsToDelete(transcript, wordsToDelete);
            Assert.Equal(expectedTranscript, transcript);
        }

        [Fact]
        public void DeleteWordsToDeleteNoEmtpySpaceTest()
        {
            String transcript =         "Hand, die die Hand mit der Hand nahm.";
            String expectedTranscript = ", die die Hand mit der Hand nahm.";

            char[] delims = { '.', ',', '?', '!', ' ' };
            string[] wordsFromTranscript = transcript.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            LinkedList<WordToDelete> wordsToDelete = new LinkedList<WordToDelete>();
            WordToDelete wordToDelete = new WordToDelete(transcript, "Hand", 0, wordsFromTranscript);
            wordsToDelete.AddFirst(wordToDelete);

            transcript = Helper.DeleteWordsToDelete(transcript, wordsToDelete);
            Assert.Equal(expectedTranscript, transcript);
        }

        [Fact]
        public void DeleteWordsToDeleteEmtpySpaceRightTest()
        {
            String transcript =         "Hand die die Hand mit der Hand nahm.";
            String expectedTranscript = "die die Hand mit der Hand nahm.";

            char[] delims = { '.', ',', '?', '!', ' ' };
            string[] wordsFromTranscript = transcript.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            LinkedList<WordToDelete> wordsToDelete = new LinkedList<WordToDelete>();
            WordToDelete wordToDelete = new WordToDelete(transcript, "Hand", 0, wordsFromTranscript);
            wordsToDelete.AddFirst(wordToDelete);

            transcript = Helper.DeleteWordsToDelete(transcript, wordsToDelete);
            Assert.Equal(expectedTranscript, transcript);
        }
    }
}
