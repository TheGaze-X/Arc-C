using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020039F6 RID: 14838
	[Token(Token = "0x20039F6")]
	public class UIExpBar : MonoBehaviour
	{
		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x060176C2 RID: 95938 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060176C3 RID: 95939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003816")]
		public string currentExp
		{
			[Token(Token = "0x60176C2")]
			[Address(RVA = "0xFC3410", Offset = "0xFC2010", VA = "0x180FC3410")]
			get
			{
				return null;
			}
			[Token(Token = "0x60176C3")]
			[Address(RVA = "0xFC36D0", Offset = "0xFC22D0", VA = "0x180FC36D0")]
			set
			{
			}
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x060176C4 RID: 95940 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060176C5 RID: 95941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003817")]
		public string limitExp
		{
			[Token(Token = "0x60176C4")]
			[Address(RVA = "0xFC35F0", Offset = "0xFC21F0", VA = "0x180FC35F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60176C5")]
			[Address(RVA = "0xFC3860", Offset = "0xFC2460", VA = "0x180FC3860")]
			set
			{
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x060176C6 RID: 95942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060176C7 RID: 95943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003818")]
		public string level
		{
			[Token(Token = "0x60176C6")]
			[Address(RVA = "0xFC3530", Offset = "0xFC2130", VA = "0x180FC3530")]
			get
			{
				return null;
			}
			[Token(Token = "0x60176C7")]
			[Address(RVA = "0xFC37B0", Offset = "0xFC23B0", VA = "0x180FC37B0")]
			set
			{
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x060176C8 RID: 95944 RVA: 0x00096630 File Offset: 0x00094830
		// (set) Token: 0x060176C9 RID: 95945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003819")]
		public float currentProgress
		{
			[Token(Token = "0x60176C8")]
			[Address(RVA = "0xFC3460", Offset = "0xFC2060", VA = "0x180FC3460")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60176C9")]
			[Address(RVA = "0xFC3720", Offset = "0xFC2320", VA = "0x180FC3720")]
			set
			{
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x060176CA RID: 95946 RVA: 0x00096648 File Offset: 0x00094848
		// (set) Token: 0x060176CB RID: 95947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700381A")]
		public float additionProgress
		{
			[Token(Token = "0x60176CA")]
			[Address(RVA = "0xFC3340", Offset = "0xFC1F40", VA = "0x180FC3340")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60176CB")]
			[Address(RVA = "0xFC3640", Offset = "0xFC2240", VA = "0x180FC3640")]
			set
			{
			}
		}

		// Token: 0x060176CC RID: 95948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176CC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIExpBar()
		{
		}

		// Token: 0x0401C4C2 RID: 115906
		[Token(Token = "0x401C4C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StretchProgressBar _currentBar;

		// Token: 0x0401C4C3 RID: 115907
		[Token(Token = "0x401C4C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StretchProgressBar _additionBar;

		// Token: 0x0401C4C4 RID: 115908
		[Token(Token = "0x401C4C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _currentExp;

		// Token: 0x0401C4C5 RID: 115909
		[Token(Token = "0x401C4C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _limitExp;

		// Token: 0x0401C4C6 RID: 115910
		[Token(Token = "0x401C4C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _level;
	}
}
