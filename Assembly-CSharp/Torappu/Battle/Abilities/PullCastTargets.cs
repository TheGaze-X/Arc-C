using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C23 RID: 11299
	[Token(Token = "0x2002C23")]
	public class PullCastTargets : AbilityStandard.Behaviour
	{
		// Token: 0x06013152 RID: 78162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013152")]
		[Address(RVA = "0xB215D0", Offset = "0xB201D0", VA = "0x180B215D0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013153 RID: 78163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013153")]
		[Address(RVA = "0xB21170", Offset = "0xB1FD70", VA = "0x180B21170", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013154 RID: 78164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013154")]
		[Address(RVA = "0xB21210", Offset = "0xB1FE10", VA = "0x180B21210", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013155 RID: 78165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013155")]
		[Address(RVA = "0xB21400", Offset = "0xB20000", VA = "0x180B21400", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06013156 RID: 78166 RVA: 0x000748B0 File Offset: 0x00072AB0
		[Token(Token = "0x6013156")]
		[Address(RVA = "0xB21740", Offset = "0xB20340", VA = "0x180B21740")]
		private int _RegisterPullRemainingTime()
		{
			return 0;
		}

		// Token: 0x06013157 RID: 78167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6013157")]
		[Address(RVA = "0xB21670", Offset = "0xB20270", VA = "0x180B21670")]
		private IEnumerator _DoLink(Enemy target)
		{
			return null;
		}

		// Token: 0x06013158 RID: 78168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013158")]
		[Address(RVA = "0xB21870", Offset = "0xB20470", VA = "0x180B21870")]
		public PullCastTargets()
		{
		}

		// Token: 0x06013159 RID: 78169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013159")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601315A RID: 78170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601315A")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0601315B RID: 78171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601315B")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x0601315C RID: 78172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601315C")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040158C2 RID: 88258
		[Token(Token = "0x40158C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _pullSourceOffset;

		// Token: 0x040158C3 RID: 88259
		[Token(Token = "0x40158C3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _pullDuration;

		// Token: 0x040158C4 RID: 88260
		[Token(Token = "0x40158C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _forceKey;

		// Token: 0x040158C5 RID: 88261
		[Token(Token = "0x40158C5")]
		[FieldOffset(Offset = "0x30")]
		private List<FP> m_pullRemainingTimeList;

		// Token: 0x040158C6 RID: 88262
		[Token(Token = "0x40158C6")]
		[FieldOffset(Offset = "0x38")]
		protected int m_pullForceLevel;

		// Token: 0x040158C7 RID: 88263
		[Token(Token = "0x40158C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158C8 RID: 88264
		[Token(Token = "0x40158C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040158C9 RID: 88265
		[Token(Token = "0x40158C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040158CA RID: 88266
		[Token(Token = "0x40158CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040158CB RID: 88267
		[Token(Token = "0x40158CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterPullRemainingTime;

		// Token: 0x040158CC RID: 88268
		[Token(Token = "0x40158CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoLink;

		// Token: 0x040158CD RID: 88269
		[Token(Token = "0x40158CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
