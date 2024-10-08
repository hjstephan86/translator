# Translate speech in C# for .NET Framework for Windows

This project is a console application for translating speech with C# under the .NET Framework (version 4.8 or above) using the Speechmatics .NET client, DeepL .NET client, and Speech SDK for Windows.
The Speechmatics API is used for speech-to-text transcription, the DeepL API is used for translation, and the Azure Speech API is used for text-to-speech.

## Prerequisites

* Authentication keys for Speechmatics, DeepL, and Azure.
* A Windows PC with a working microphone.
* [Microsoft Visual Studio 2022](https://visualstudio.microsoft.com/de/downloads/), Community Edition or higher.
* The **.NET desktop development** workload in Visual Studio.
  You can enable it in **Tools** \> **Get Tools and Features**.

## Build the project

* **By building this project you will download the Speechmatics .NET client, DeepL .NET client, and Microsoft Cognitive Services Speech SDK.**
* Start Microsoft Visual Studio 2022 and select **File** \> **Open** \> **Project/Solution**.
* Navigate to the folder containing this project, and select the solution file contained within it.
* Edit the XML section `appSettings` of the `App.config` file:
  * Change the value of `SpeechmaticsAuthKey` to the authentication key generated by Speechmatics.
  * Change the value of `SpeechmaticsRtUrl` to the service url of Speechmatics, i.e., [wss://eu2.rt.speechmatics.com/v2/de](wss://eu2.rt.speechmatics.com/v2/de).
  * Change the value of `SpeechmaticsLanguage` to the language Speechmatics should transcribe. For all suppported languages see [https://docs.speechmatics.com/introduction/supported-languages](https://docs.speechmatics.com/introduction/supported-languages).
  * Change the value of `DeepLAuthKey` to the authentication key generated by DeepL.
  * Change the value of `DeepLFromLanguage` to the language which should be detected for translation, e.g., `de`, `en`, `uk`. For all supported languages see [https://support.deepl.com/hc/en-us/articles/360019925219-Languages-included-in-DeepL-Pro](https://support.deepl.com/hc/en-us/articles/360019925219-Languages-included-in-DeepL-Pro).
  * Change the value of `DeepLTargetLanguage` to the language to which translation should be performed.
  * Change the value of `AzureAuthKey` with your own subscription key. Use the `Speech` resource in Azure (not the `Speech Recognition` resource).
  * Change the value of `AzureRegion` with the service region of your subscription.
    For example, replace with `westus` if you are using the 30-day free trial subscription. Make sure the region in your Azure resource matches the region you put into the `App.config`, otherwise you'll get a 401 unauthorized access error.
  * Change the value of `AzureTargetVoice` to the voice which should be used for translation, e.g., `de-DE-BerndNeural`, `en-US-ChristopherNeural`, `uk-UA-OstapNeural`. 
* Set the active solution configuration and platform to the desired values under **Build** \> **Configuration Manager**:
  * On a 64-bit Windows installation, choose `x64` as active solution platform.
  * On a 32-bit Windows installation, choose `x86` as active solution platform.
* Press Ctrl+Shift+B, or select **Build** \> **Build Solution**.

## Run the project

To debug the app and then run it, press F5 or use **Debug** \> **Start Debugging**. To run the app without debugging, press Ctrl+F5 or use **Debug** \> **Start Without Debugging**.

## References
* [Introduction into Speechmatics API](https://docs.speechmatics.com/introduction)
* [DeepL API](https://www.deepl.com/docs-api)
* [Azure Speech SDK API reference for C#](https://aka.ms/csspeech/csharpref)
