using System;
namespace WebAPI.Data
{
	public static class Data
	{
		public static List<BluePrint> Excercises = new List<BluePrint>
		{
			new BluePrint
			{
                Id = 1,
				ToCalculator = "5 + 5",
				Tokens = new List<int>
				{
					9, 15, 10, 5
				},
				CorrectIndex = 2
			},
            new BluePrint
            {
                Id = 2,
                ToCalculator = "12 - 6",
                Tokens = new List<int>
                {
                    6, 11, 5, 0
                },
                CorrectIndex = 0
            },
            new BluePrint
            {
                Id = 3,
                ToCalculator = "9 * 3",
                Tokens = new List<int>
                {
                    33, 27, 9, 10
                },
                CorrectIndex = 1
            },
            new BluePrint
            {
                Id = 4,
                ToCalculator = "65 + 12",
                Tokens = new List<int>
                {
                    90, 67, 72, 77
                },
                CorrectIndex = 3
            },
            new BluePrint
            {
                Id = 5,
                ToCalculator = "100 - 44",
                Tokens = new List<int>
                {
                    40, 50, 60, 56
                },
                CorrectIndex = 3
            },
            new BluePrint
            {
                Id = 6,
                ToCalculator = "25 * 3",
                Tokens = new List<int>
                {
                    70, 100, 75, 50
                },
                CorrectIndex = 2
            },
            new BluePrint
            {
                Id = 7,
                ToCalculator = "50 / 2",
                Tokens = new List<int>
                {
                    25, 50, 40, 30
                },
                CorrectIndex = 0
            },
            new BluePrint
            {
                Id = 8,
                ToCalculator = "20 / 4",
                Tokens = new List<int>
                {
                    4, 5, 10, 20
                },
                CorrectIndex = 1
            },
            new BluePrint
            {
                Id = 9,
                ToCalculator = "100 * 2",
                Tokens = new List<int>
                {
                    100, 190, 300, 200
                },
                CorrectIndex = 3
            },
            new BluePrint
            {
                Id = 10,
                ToCalculator = "250 + 100",
                Tokens = new List<int>
                {
                    500, 300, 350, 250
                },
                CorrectIndex = 2
            }
        };
	}
}

