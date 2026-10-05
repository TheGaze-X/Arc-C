using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D47 RID: 27975
	[Token(Token = "0x2006D47")]
	[RequireComponent(typeof(Image))]
	[DisallowMultipleComponent]
	public class ActivityDynamicImage : UIDynImage, IHotfixable
	{
		// Token: 0x06027E03 RID: 163331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E03")]
		[Address(RVA = "0x22F0330", Offset = "0x22EEF30", VA = "0x1822F0330")]
		public string EditorOnlyGetImagePath()
		{
			return null;
		}

		// Token: 0x06027E04 RID: 163332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E04")]
		[Address(RVA = "0x22F0390", Offset = "0x22EEF90", VA = "0x1822F0390")]
		public void Render(string actId)
		{
		}

		// Token: 0x06027E05 RID: 163333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E05")]
		[Address(RVA = "0x22F02A0", Offset = "0x22EEEA0", VA = "0x1822F02A0")]
		public void ChangeColor(Color color)
		{
		}

		// Token: 0x06027E06 RID: 163334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E06")]
		[Address(RVA = "0x22F0420", Offset = "0x22EF020", VA = "0x1822F0420")]
		public ActivityDynamicImage()
		{
		}

		// Token: 0x04038864 RID: 231524
		[Token(Token = "0x4038864")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _imagePath;

		// Token: 0x04038865 RID: 231525
		[Token(Token = "0x4038865")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _colorChangeAble;

		// Token: 0x04038866 RID: 231526
		[Token(Token = "0x4038866")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _spriteChangeAble;

		// Token: 0x04038867 RID: 231527
		[Token(Token = "0x4038867")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EditorOnlyGetImagePath;

		// Token: 0x04038868 RID: 231528
		[Token(Token = "0x4038868")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038869 RID: 231529
		[Token(Token = "0x4038869")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ChangeColor;

		// Token: 0x0403886A RID: 231530
		[Token(Token = "0x403886A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
