namespace DotVVM.Contrib.GoogleMap.Samples.ViewModels
{
	public class AddressViewModel : MasterViewModel
    {
        public string Address { get; set; } = "Chicken Dinner Rd Idaho 83607, USA";

        public void ChangeAddress()
        {
            Address = "Zzyzx RdCalifornia, USA";
        }
	}
}

