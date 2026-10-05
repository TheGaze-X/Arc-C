using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003254 RID: 12884
	[Token(Token = "0x2003254")]
	public class Act45SideSceneEffectBehaviour : Effect.Behaviour
	{
		// Token: 0x060146F0 RID: 83696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F0")]
		[Address(RVA = "0xC993C0", Offset = "0xC97FC0", VA = "0x180C993C0", Slot = "9")]
		public override void OnPostImport()
		{
		}

		// Token: 0x060146F1 RID: 83697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F1")]
		[Address(RVA = "0xC992D0", Offset = "0xC97ED0", VA = "0x180C992D0")]
		private void Awake()
		{
		}

		// Token: 0x060146F2 RID: 83698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F2")]
		[Address(RVA = "0xC99530", Offset = "0xC98130", VA = "0x180C99530")]
		private void Update()
		{
		}

		// Token: 0x060146F3 RID: 83699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F3")]
		[Address(RVA = "0xC99680", Offset = "0xC98280", VA = "0x180C99680")]
		public Act45SideSceneEffectBehaviour()
		{
		}

		// Token: 0x060146F4 RID: 83700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F4")]
		[Address(RVA = "0xC99520", Offset = "0xC98120", VA = "0x180C99520")]
		private void <>xLuaBaseProxy_OnPostImport()
		{
		}

		// Token: 0x0401822C RID: 98860
		[Token(Token = "0x401822C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _left;

		// Token: 0x0401822D RID: 98861
		[Token(Token = "0x401822D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _up;

		// Token: 0x0401822E RID: 98862
		[Token(Token = "0x401822E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _right;

		// Token: 0x0401822F RID: 98863
		[Token(Token = "0x401822F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _down;

		// Token: 0x04018230 RID: 98864
		[Token(Token = "0x4018230")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_currentOn;

		// Token: 0x04018231 RID: 98865
		[Token(Token = "0x4018231")]
		[FieldOffset(Offset = "0x48")]
		private SharedConsts.Direction lightSourceDirection;

		// Token: 0x04018232 RID: 98866
		[Token(Token = "0x4018232")]
		[FieldOffset(Offset = "0x50")]
		private Act45SideManager m_manager;

		// Token: 0x04018233 RID: 98867
		[Token(Token = "0x4018233")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostImport;

		// Token: 0x04018234 RID: 98868
		[Token(Token = "0x4018234")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018235 RID: 98869
		[Token(Token = "0x4018235")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018236 RID: 98870
		[Token(Token = "0x4018236")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
