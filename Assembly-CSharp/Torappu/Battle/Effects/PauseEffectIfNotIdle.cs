using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003244 RID: 12868
	[Token(Token = "0x2003244")]
	public class PauseEffectIfNotIdle : Effect.Behaviour, IHotfixable
	{
		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x06014698 RID: 83608 RVA: 0x00086D00 File Offset: 0x00084F00
		[Token(Token = "0x1700305A")]
		public bool needCheckFaceSwitch
		{
			[Token(Token = "0x6014698")]
			[Address(RVA = "0xCA7FA0", Offset = "0xCA6BA0", VA = "0x180CA7FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014699 RID: 83609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014699")]
		[Address(RVA = "0xCA7DA0", Offset = "0xCA69A0", VA = "0x180CA7DA0")]
		private void Update()
		{
		}

		// Token: 0x0601469A RID: 83610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601469A")]
		[Address(RVA = "0xCA7F40", Offset = "0xCA6B40", VA = "0x180CA7F40")]
		public PauseEffectIfNotIdle()
		{
		}

		// Token: 0x040181B2 RID: 98738
		[Token(Token = "0x40181B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _needCheckFaceSwitch;

		// Token: 0x040181B3 RID: 98739
		[Token(Token = "0x40181B3")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[Inspect("needCheckFaceSwitch")]
		private bool _pauseWhenBack;

		// Token: 0x040181B4 RID: 98740
		[Token(Token = "0x40181B4")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		[Inspect("needCheckFaceSwitch")]
		private bool _pauseWhenFront;

		// Token: 0x040181B5 RID: 98741
		[Token(Token = "0x40181B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needCheckFaceSwitch;

		// Token: 0x040181B6 RID: 98742
		[Token(Token = "0x40181B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181B7 RID: 98743
		[Token(Token = "0x40181B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
