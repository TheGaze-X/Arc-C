using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007849 RID: 30793
	[Token(Token = "0x2007849")]
	public class Act1MainSSApCostRewardDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B2FB RID: 176891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2FB")]
		[Address(RVA = "0x26EF790", Offset = "0x26EE390", VA = "0x1826EF790")]
		public void Render(Act1MainSSApCostRewardDetailView.Param param)
		{
		}

		// Token: 0x0602B2FC RID: 176892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2FC")]
		[Address(RVA = "0x26EF8C0", Offset = "0x26EE4C0", VA = "0x1826EF8C0")]
		public Act1MainSSApCostRewardDetailView()
		{
		}

		// Token: 0x0403E6D6 RID: 255702
		[Token(Token = "0x403E6D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _mainDescText;

		// Token: 0x0403E6D7 RID: 255703
		[Token(Token = "0x403E6D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _apDescText;

		// Token: 0x0403E6D8 RID: 255704
		[Token(Token = "0x403E6D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _endDescText;

		// Token: 0x0403E6D9 RID: 255705
		[Token(Token = "0x403E6D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E6DA RID: 255706
		[Token(Token = "0x403E6DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200784A RID: 30794
		[Token(Token = "0x200784A")]
		public class Param
		{
			// Token: 0x0602B2FD RID: 176893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B2FD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403E6DB RID: 255707
			[Token(Token = "0x403E6DB")]
			[FieldOffset(Offset = "0x10")]
			public string mainDesc;

			// Token: 0x0403E6DC RID: 255708
			[Token(Token = "0x403E6DC")]
			[FieldOffset(Offset = "0x18")]
			public string apDesc;

			// Token: 0x0403E6DD RID: 255709
			[Token(Token = "0x403E6DD")]
			[FieldOffset(Offset = "0x20")]
			public string endDesc;
		}
	}
}
