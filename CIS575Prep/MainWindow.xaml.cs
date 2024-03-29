﻿using System.Windows;

namespace CIS575Prep
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public int[] IntArray { get; set; } = [];

		public MainWindow()
		{
			InitializeComponent();
			IntArray = [4, 5, 2, 9, 3, 4];
			//IntArray = [4, 5, 2, 9, 3, 8];
			uxArray.Content = $"IntArray = [{IntArray[0]}, {IntArray[1]}, {IntArray[2]}, {IntArray[3]}, {IntArray[4]}, {IntArray[5]}]";
			CheckOccurs(IntArray);
		}

		public void CheckOccurs(int[] arr)
		{
			InspectArray(IntArray, 'A');
			InspectArray(IntArray, 'B');
			InspectArray(IntArray, 'C');
			InspectArray(IntArray, 'D');
			InspectArray(IntArray, 'E');
			InspectArray(IntArray, 'F');
		}

		public void InspectArray(int[] arr, char order)
		{
			bool occur = default;
			switch (order)
			{
				case ('A'):
					occur = NoIntOccursTwiceA(IntArray);
					if (occur) { uxLabelA.Content = "A: Occurs"; }
					else { uxLabelA.Content = "A: No occurs"; }
					break;
				case ('B'):
					occur = NoIntOccursTwiceB(IntArray);
					if (occur) { uxLabelB.Content = "B: Occurs"; }
					else { uxLabelB.Content = "B: No occurs"; }
					break;
				case ('C'):
					occur = NoIntOccursTwiceC(IntArray);
					if (occur) { uxLabelC.Content = "C: Occurs"; }
					else { uxLabelC.Content = "C: No occurs"; }
					break;
				case ('D'):
					occur = NoIntOccursTwiceD(IntArray);
					if (occur) { uxLabelD.Content = "D: Occurs"; }
					else { uxLabelD.Content = "D: No occurs"; }
					break;
				case ('E'):
					occur = NoIntOccursTwiceE(IntArray);
					if (occur) { uxLabelE.Content = "E: Occurs"; }
					else { uxLabelE.Content = "E: No occurs"; }
					break;
				case ('F'):
					occur = NoIntOccursTwiceF(IntArray);
					if (occur) { uxLabelF.Content = "F: Occurs"; }
					else { uxLabelF.Content = "F: No occurs"; }
					break;
			}
		}

		/// <summary>
		/// forall i in 1..n, forall j in 1..n, i != j implies B[i] != B[j]
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceA(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (i != j)
					{
						if (!(arr[i] != arr[j]))
						{
							occurs = true;
						}
					}
				}
			}
			return occurs;
		}

		/// <summary>
		/// forall i in 1..n, forall j in 1..n, B[i] = B[j] implies i = j 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceB(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
					{
						if (!(i == j))
						{
							occurs = true;
						}
					}
				}
			}
			return occurs;
		}

		/// <summary>
		/// forall i in 1..n, forall j in 1..n, B[i] != B[j] 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceC(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (!(arr[i] != arr[j]))
					{
						occurs = true;
					}
				}
			}
			return occurs;
		}

		/// <summary>
		/// forall i in 1..n, forall j in 1..n, i != j and B[i] != B[j] 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceD(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (i != j)
					{
						if (!(arr[i] != arr[j]))
						{
							occurs = true;
						}
					}
				}
			}
			return occurs;
		}

		/// <summary>
		/// forall i in 1..n, forall j in i+1..n, B[i] != B[j] 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceE(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (!(arr[i] != arr[j]))
					{
						occurs = true;
					}
				}
			}
			return occurs;
		}

		/// <summary>
		/// forall i in 1..n-1, B[i] != B[i+1]
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public bool NoIntOccursTwiceF(int[] arr)
		{
			bool occurs = false;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (!(arr[i] != arr[i + 1]))
				{
					occurs = true;
				}
			}
			return occurs;
		}
	}
}