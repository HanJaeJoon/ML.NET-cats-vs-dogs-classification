using MLModel_ConsoleApp;

List<MLModel.ModelInput> sampleImages = new()
{
    new MLModel.ModelInput
    {
        ImageSource = File.ReadAllBytes(@"images\pepper1.jpg"),
    },
    new MLModel.ModelInput
    {
        ImageSource = File.ReadAllBytes(@"images\pepper2.jpg"),
    },
};

sampleImages.ForEach(image =>
{
    MLModel.ModelOutput predictionResult = MLModel.Predict(image);
    Console.WriteLine($@"
        Predicted Label value: {predictionResult.PredictedLabel}
        Predicted Label scores: [{string.Join(",", predictionResult.Score)}]
    ");
});
