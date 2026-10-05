using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DB;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.CETest
{
	// Token: 0x02001794 RID: 6036
	[Token(Token = "0x2001794")]
	public class CETestBattleLoader : AbstractBattleLoader
	{
		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105B")]
		private static IConverter plainTextConverter
		{
			[Token(Token = "0x6009889")]
			[Address(RVA = "0x313B7F0", Offset = "0x313A3F0", VA = "0x18313B7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105C")]
		private static IConverter decrypter
		{
			[Token(Token = "0x600988A")]
			[Address(RVA = "0x313B750", Offset = "0x313A350", VA = "0x18313B750")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600988B")]
		[Address(RVA = "0x313B590", Offset = "0x313A190", VA = "0x18313B590")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600988C")]
		[Address(RVA = "0x313B640", Offset = "0x313A240", VA = "0x18313B640")]
		private IEnumerator _DoLoad()
		{
			return null;
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988D")]
		[Address(RVA = "0x313B6F0", Offset = "0x313A2F0", VA = "0x18313B6F0")]
		public CETestBattleLoader()
		{
		}

		// Token: 0x04008E78 RID: 36472
		[Token(Token = "0x4008E78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceCollector _collector;

		// Token: 0x04008E79 RID: 36473
		[Token(Token = "0x4008E79")]
		[FieldOffset(Offset = "0x20")]
		private float m_startLoadingTime;

		// Token: 0x04008E7A RID: 36474
		[Token(Token = "0x4008E7A")]
		[FieldOffset(Offset = "0x28")]
		private List<PoolManager.ObjectConfig> m_configs;

		// Token: 0x04008E7B RID: 36475
		[Token(Token = "0x4008E7B")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<string> m_resourceSet;

		// Token: 0x04008E7C RID: 36476
		[Token(Token = "0x4008E7C")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_packedStages;

		// Token: 0x04008E7D RID: 36477
		[Token(Token = "0x4008E7D")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_plainTextConverter;

		// Token: 0x04008E7E RID: 36478
		[Token(Token = "0x4008E7E")]
		[FieldOffset(Offset = "0x8")]
		private static IConverter m_decrypter;

		// Token: 0x04008E7F RID: 36479
		[Token(Token = "0x4008E7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x04008E80 RID: 36480
		[Token(Token = "0x4008E80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x04008E81 RID: 36481
		[Token(Token = "0x4008E81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04008E82 RID: 36482
		[Token(Token = "0x4008E82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoLoad;

		// Token: 0x04008E83 RID: 36483
		[Token(Token = "0x4008E83")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
