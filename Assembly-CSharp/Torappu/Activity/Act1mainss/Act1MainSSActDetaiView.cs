using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x0200783D RID: 30781
	[Token(Token = "0x200783D")]
	public class Act1MainSSActDetaiView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B2D0 RID: 176848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D0")]
		[Address(RVA = "0x26EE3E0", Offset = "0x26ECFE0", VA = "0x1826EE3E0")]
		public void Render(Act1MainSSActDetaiView.Param param)
		{
		}

		// Token: 0x0602B2D1 RID: 176849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D1")]
		[Address(RVA = "0x26EE550", Offset = "0x26ED150", VA = "0x1826EE550")]
		public Act1MainSSActDetaiView()
		{
		}

		// Token: 0x0403E698 RID: 255640
		[Token(Token = "0x403E698")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _primaryDescText;

		// Token: 0x0403E699 RID: 255641
		[Token(Token = "0x403E699")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _entryDescText;

		// Token: 0x0403E69A RID: 255642
		[Token(Token = "0x403E69A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _secondaryDescText;

		// Token: 0x0403E69B RID: 255643
		[Token(Token = "0x403E69B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _rewardDescText;

		// Token: 0x0403E69C RID: 255644
		[Token(Token = "0x403E69C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E69D RID: 255645
		[Token(Token = "0x403E69D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200783E RID: 30782
		[Token(Token = "0x200783E")]
		public class Param
		{
			// Token: 0x0602B2D2 RID: 176850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B2D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403E69E RID: 255646
			[Token(Token = "0x403E69E")]
			[FieldOffset(Offset = "0x10")]
			public string primaryDesc;

			// Token: 0x0403E69F RID: 255647
			[Token(Token = "0x403E69F")]
			[FieldOffset(Offset = "0x18")]
			public string entryDesc;

			// Token: 0x0403E6A0 RID: 255648
			[Token(Token = "0x403E6A0")]
			[FieldOffset(Offset = "0x20")]
			public string secondaryDesc;

			// Token: 0x0403E6A1 RID: 255649
			[Token(Token = "0x403E6A1")]
			[FieldOffset(Offset = "0x28")]
			public string rewardDesc;
		}
	}
}
