namespace DataStore
{
	public enum LabelType
	{
		Sale,
		Regular,
		Original,
		Clearance,
		Group,
		None, // there exists a price, but it is not labeld
		NoPrice, // there is no price
	}

	public enum PriceType
	{
		Single, // $15
		Range, // $15 - $20
		Hybrid, // $15 or 2/$25
		Bulk, // 2 / $25
		NoPrice, // no price is given
	}

	public enum Gender
	{
		Male,
		Female,
		NotSpecified
	}
}