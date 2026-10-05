using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200690A RID: 26890
	[Token(Token = "0x200690A")]
	public class MainStageButtonOnMapHolder : StageButtonOnMapHolder
	{
		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x06026842 RID: 157762 RVA: 0x000CB6D0 File Offset: 0x000C98D0
		[Token(Token = "0x17005AED")]
		[Inspect]
		public bool isTrainingStage
		{
			[Token(Token = "0x6026842")]
			[Address(RVA = "0x21916F0", Offset = "0x21902F0", VA = "0x1821916F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026843 RID: 157763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026843")]
		[Address(RVA = "0x2191690", Offset = "0x2190290", VA = "0x182191690")]
		public MainStageButtonOnMapHolder()
		{
		}

		// Token: 0x040364C1 RID: 222401
		[Token(Token = "0x40364C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private bool _isTrainingStage;

		// Token: 0x040364C2 RID: 222402
		[Token(Token = "0x40364C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTrainingStage;

		// Token: 0x040364C3 RID: 222403
		[Token(Token = "0x40364C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
