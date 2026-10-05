using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A99 RID: 31385
	[Token(Token = "0x2007A99")]
	public class Act12sideMissionState : Act12sideGenericState
	{
		// Token: 0x0602BF86 RID: 180102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF86")]
		[Address(RVA = "0x27E0A70", Offset = "0x27DF670", VA = "0x1827E0A70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF87 RID: 180103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF87")]
		[Address(RVA = "0x27E09A0", Offset = "0x27DF5A0", VA = "0x1827E09A0", Slot = "31")]
		protected override void InitIfNot()
		{
		}

		// Token: 0x0602BF88 RID: 180104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF88")]
		[Address(RVA = "0x27E0940", Offset = "0x27DF540", VA = "0x1827E0940", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF89 RID: 180105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF89")]
		[Address(RVA = "0x27E0D10", Offset = "0x27DF910", VA = "0x1827E0D10")]
		public Act12sideMissionState()
		{
		}

		// Token: 0x0602BF8A RID: 180106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF8A")]
		[Address(RVA = "0x27DD830", Offset = "0x27DC430", VA = "0x1827DD830")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BF8B RID: 180107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF8B")]
		[Address(RVA = "0x27DA570", Offset = "0x27D9170", VA = "0x1827DA570")]
		private void <>xLuaBaseProxy_InitIfNot()
		{
		}

		// Token: 0x0403FB04 RID: 260868
		[Token(Token = "0x403FB04")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act12sideMissionView _view;

		// Token: 0x0403FB05 RID: 260869
		[Token(Token = "0x403FB05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FB06 RID: 260870
		[Token(Token = "0x403FB06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403FB07 RID: 260871
		[Token(Token = "0x403FB07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FB08 RID: 260872
		[Token(Token = "0x403FB08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
