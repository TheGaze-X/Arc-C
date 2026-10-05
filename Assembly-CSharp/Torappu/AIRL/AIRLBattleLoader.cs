using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DB;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.AIRL
{
	// Token: 0x02002025 RID: 8229
	[Token(Token = "0x2002025")]
	public class AIRLBattleLoader : AbstractBattleLoader
	{
		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017F7")]
		private static IConverter plainTextConverter
		{
			[Token(Token = "0x600CAB9")]
			[Address(RVA = "0x34BA750", Offset = "0x34B9350", VA = "0x1834BA750")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CABA")]
		[Address(RVA = "0x34BA530", Offset = "0x34B9130", VA = "0x1834BA530")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CABB")]
		[Address(RVA = "0x34BA5E0", Offset = "0x34B91E0", VA = "0x1834BA5E0")]
		private IEnumerator _DoLoad()
		{
			return null;
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x0600CABC RID: 51900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017F8")]
		private static string BATTLE_SCENE
		{
			[Token(Token = "0x600CABC")]
			[Address(RVA = "0x34BA6F0", Offset = "0x34B92F0", VA = "0x1834BA6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CABD")]
		[Address(RVA = "0x34BA690", Offset = "0x34B9290", VA = "0x1834BA690")]
		public AIRLBattleLoader()
		{
		}

		// Token: 0x0400D470 RID: 54384
		[Token(Token = "0x400D470")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceCollector _collector;

		// Token: 0x0400D471 RID: 54385
		[Token(Token = "0x400D471")]
		[FieldOffset(Offset = "0x20")]
		private float m_startLoadingTime;

		// Token: 0x0400D472 RID: 54386
		[Token(Token = "0x400D472")]
		[FieldOffset(Offset = "0x28")]
		private List<PoolManager.ObjectConfig> m_configs;

		// Token: 0x0400D473 RID: 54387
		[Token(Token = "0x400D473")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<string> m_resourceSet;

		// Token: 0x0400D474 RID: 54388
		[Token(Token = "0x400D474")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_packedStages;

		// Token: 0x0400D475 RID: 54389
		[Token(Token = "0x400D475")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_plainTextConverter;

		// Token: 0x0400D476 RID: 54390
		[Token(Token = "0x400D476")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x0400D477 RID: 54391
		[Token(Token = "0x400D477")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D478 RID: 54392
		[Token(Token = "0x400D478")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoLoad;

		// Token: 0x0400D479 RID: 54393
		[Token(Token = "0x400D479")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_BATTLE_SCENE;

		// Token: 0x0400D47A RID: 54394
		[Token(Token = "0x400D47A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
