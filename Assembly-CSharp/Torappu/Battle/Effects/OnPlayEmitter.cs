using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200323B RID: 12859
	[Token(Token = "0x200323B")]
	public class OnPlayEmitter : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0601465B RID: 83547 RVA: 0x00086B50 File Offset: 0x00084D50
		[Token(Token = "0x1700304C")]
		private bool instant
		{
			[Token(Token = "0x601465B")]
			[Address(RVA = "0xCA70C0", Offset = "0xCA5CC0", VA = "0x180CA70C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601465C RID: 83548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601465C")]
		[Address(RVA = "0xCA6750", Offset = "0xCA5350", VA = "0x180CA6750", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x0601465D RID: 83549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601465D")]
		[Address(RVA = "0xCA63F0", Offset = "0xCA4FF0", VA = "0x180CA63F0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601465E RID: 83550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601465E")]
		[Address(RVA = "0xCA6F50", Offset = "0xCA5B50", VA = "0x180CA6F50")]
		protected void _OnPlayInternal()
		{
		}

		// Token: 0x0601465F RID: 83551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601465F")]
		[Address(RVA = "0xCA6820", Offset = "0xCA5420", VA = "0x180CA6820", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014660 RID: 83552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014660")]
		[Address(RVA = "0xCA68A0", Offset = "0xCA54A0", VA = "0x180CA68A0", Slot = "8")]
		public override void OnPaused(bool paused)
		{
		}

		// Token: 0x06014661 RID: 83553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014661")]
		[Address(RVA = "0xCA66B0", Offset = "0xCA52B0", VA = "0x180CA66B0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014662 RID: 83554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014662")]
		[Address(RVA = "0xCA6A60", Offset = "0xCA5660", VA = "0x180CA6A60")]
		private IEnumerator _DoEmitWithPreDelay()
		{
			return null;
		}

		// Token: 0x06014663 RID: 83555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014663")]
		[Address(RVA = "0xCA6B10", Offset = "0xCA5710", VA = "0x180CA6B10")]
		private void _DoEmit()
		{
		}

		// Token: 0x06014664 RID: 83556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014664")]
		[Address(RVA = "0xCA6650", Offset = "0xCA5250", VA = "0x180CA6650", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014665 RID: 83557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014665")]
		[Address(RVA = "0xCA7060", Offset = "0xCA5C60", VA = "0x180CA7060")]
		public OnPlayEmitter()
		{
		}

		// Token: 0x06014666 RID: 83558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014666")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x06014667 RID: 83559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014667")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014668 RID: 83560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014668")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x06014669 RID: 83561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014669")]
		[Address(RVA = "0xC9AB60", Offset = "0xC99760", VA = "0x180C9AB60")]
		private void <>xLuaBaseProxy_OnPaused(bool P0)
		{
		}

		// Token: 0x04018148 RID: 98632
		[Token(Token = "0x4018148")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x04018149 RID: 98633
		[Token(Token = "0x4018149")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _instant;

		// Token: 0x0401814A RID: 98634
		[Token(Token = "0x401814A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Inspect("instant", false)]
		private float _preDelay;

		// Token: 0x0401814B RID: 98635
		[Token(Token = "0x401814B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useFaceVector;

		// Token: 0x0401814C RID: 98636
		[Token(Token = "0x401814C")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _clearWhenFinish;

		// Token: 0x0401814D RID: 98637
		[Token(Token = "0x401814D")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _keepPauseSync;

		// Token: 0x0401814E RID: 98638
		[Token(Token = "0x401814E")]
		[FieldOffset(Offset = "0x33")]
		[SerializeField]
		private bool _useSourceEffectPos;

		// Token: 0x0401814F RID: 98639
		[Token(Token = "0x401814F")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04018150 RID: 98640
		[Token(Token = "0x4018150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instant;

		// Token: 0x04018151 RID: 98641
		[Token(Token = "0x4018151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04018152 RID: 98642
		[Token(Token = "0x4018152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018153 RID: 98643
		[Token(Token = "0x4018153")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPlayInternal;

		// Token: 0x04018154 RID: 98644
		[Token(Token = "0x4018154")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018155 RID: 98645
		[Token(Token = "0x4018155")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPaused;

		// Token: 0x04018156 RID: 98646
		[Token(Token = "0x4018156")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018157 RID: 98647
		[Token(Token = "0x4018157")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoEmitWithPreDelay;

		// Token: 0x04018158 RID: 98648
		[Token(Token = "0x4018158")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoEmit;

		// Token: 0x04018159 RID: 98649
		[Token(Token = "0x4018159")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x0401815A RID: 98650
		[Token(Token = "0x401815A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
