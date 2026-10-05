using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003225 RID: 12837
	[Token(Token = "0x2003225")]
	public class EmitterRandomGroup : Effect.Behaviour, IEffectSource
	{
		// Token: 0x060145C7 RID: 83399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C7")]
		[Address(RVA = "0xC9B340", Offset = "0xC99F40", VA = "0x180C9B340", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145C8 RID: 83400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C8")]
		[Address(RVA = "0xC9B080", Offset = "0xC99C80", VA = "0x180C9B080", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060145C9 RID: 83401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C9")]
		[Address(RVA = "0xC9B3E0", Offset = "0xC99FE0", VA = "0x180C9B3E0")]
		private void _PickOneEmitter()
		{
		}

		// Token: 0x060145CA RID: 83402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CA")]
		[Address(RVA = "0xC9B130", Offset = "0xC99D30", VA = "0x180C9B130", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060145CB RID: 83403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CB")]
		[Address(RVA = "0xC9B7F0", Offset = "0xC9A3F0", VA = "0x180C9B7F0")]
		public EmitterRandomGroup()
		{
		}

		// Token: 0x060145CC RID: 83404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CC")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145CD RID: 83405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145CD")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018056 RID: 98390
		[Token(Token = "0x4018056")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effectPickFrom;

		// Token: 0x04018057 RID: 98391
		[Token(Token = "0x4018057")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _selfExcluded;

		// Token: 0x04018058 RID: 98392
		[Token(Token = "0x4018058")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _dontCheckOwner;

		// Token: 0x04018059 RID: 98393
		[Token(Token = "0x4018059")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _finishEffectWhenSelfFinish;

		// Token: 0x0401805A RID: 98394
		[Token(Token = "0x401805A")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _useMainEffectPos;

		// Token: 0x0401805B RID: 98395
		[Token(Token = "0x401805B")]
		[FieldOffset(Offset = "0x30")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x0401805C RID: 98396
		[Token(Token = "0x401805C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401805D RID: 98397
		[Token(Token = "0x401805D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401805E RID: 98398
		[Token(Token = "0x401805E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PickOneEmitter;

		// Token: 0x0401805F RID: 98399
		[Token(Token = "0x401805F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018060 RID: 98400
		[Token(Token = "0x4018060")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
