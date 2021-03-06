
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace SimpleLevelsByEnvelope
{
    public class SimpleLevelsByEnvelopeTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
                {"Envelope", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/BuildingBlocks/Levels/SimpleLevelsByEnvelope/test/Generated/SimpleLevelsByEnvelopeTest/model_dependencies/Envelope/model.json")) }, 
            };

            var result = SimpleLevelsByEnvelope.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/SimpleLevelsByEnvelopeTest/results/SimpleLevelsByEnvelopeTest.gltf", false);
            result.Model.ToGlTF("../../../Generated/SimpleLevelsByEnvelopeTest/results/SimpleLevelsByEnvelopeTest.glb");
            File.WriteAllText("../../../Generated/SimpleLevelsByEnvelopeTest/results/SimpleLevelsByEnvelopeTest.json", result.Model.ToJson());
        }

        public SimpleLevelsByEnvelopeInputs GetInput()
        {
            var inputText = @"
            {
  ""Top Level Height"": 5,
  ""Base Levels"": [
    6.2,
    4
  ],
  ""model_input_keys"": {
    ""Envelope"": ""2ed49e9a-573a-4d0b-875d-870f077d6771_3ff9f545-db8f-46d6-8deb-69e9ff7a9f35_elements.zip""
  },
  ""Subgrade Level Height"": 4
}
            ";
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SimpleLevelsByEnvelopeInputs>(inputText);
        }
    }
}