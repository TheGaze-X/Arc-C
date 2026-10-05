using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A71 RID: 10865
	[Token(Token = "0x2002A71")]
	[Serializable]
	public class SandboxEntityStatusValue : IHotfixable
	{
		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0601210B RID: 73995 RVA: 0x0006E940 File Offset: 0x0006CB40
		// (set) Token: 0x0601210C RID: 73996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A5")]
		[JsonIgnore]
		public int totalNotCollected
		{
			[Token(Token = "0x601210B")]
			[Address(RVA = "0xA2C070", Offset = "0xA2AC70", VA = "0x180A2C070")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601210C")]
			[Address(RVA = "0xA2C3A0", Offset = "0xA2AFA0", VA = "0x180A2C3A0")]
			set
			{
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0601210D RID: 73997 RVA: 0x0006E958 File Offset: 0x0006CB58
		// (set) Token: 0x0601210E RID: 73998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A6")]
		[JsonIgnore]
		public int maxStockCount
		{
			[Token(Token = "0x601210D")]
			[Address(RVA = "0xA2BF50", Offset = "0xA2AB50", VA = "0x180A2BF50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601210E")]
			[Address(RVA = "0xA2C190", Offset = "0xA2AD90", VA = "0x180A2C190")]
			set
			{
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0601210F RID: 73999 RVA: 0x0006E970 File Offset: 0x0006CB70
		// (set) Token: 0x06012110 RID: 74000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A7")]
		[JsonIgnore]
		public int droppedNotCollected
		{
			[Token(Token = "0x601210F")]
			[Address(RVA = "0xA2BEF0", Offset = "0xA2AAF0", VA = "0x180A2BEF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012110")]
			[Address(RVA = "0xA2C120", Offset = "0xA2AD20", VA = "0x180A2C120")]
			set
			{
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x06012112 RID: 74002 RVA: 0x0006E988 File Offset: 0x0006CB88
		// (set) Token: 0x06012111 RID: 74001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027A8")]
		[JsonIgnore]
		public float statusHpRatio
		{
			[Token(Token = "0x6012112")]
			[Address(RVA = "0xA2C000", Offset = "0xA2AC00", VA = "0x180A2C000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6012111")]
			[Address(RVA = "0xA2C2C0", Offset = "0xA2AEC0", VA = "0x180A2C2C0")]
			set
			{
			}
		}

		// Token: 0x06012113 RID: 74003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012113")]
		[Address(RVA = "0xA2BB30", Offset = "0xA2A730", VA = "0x180A2BB30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06012114 RID: 74004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012114")]
		[Address(RVA = "0xA2BE90", Offset = "0xA2AA90", VA = "0x180A2BE90")]
		public SandboxEntityStatusValue()
		{
		}

		// Token: 0x06012115 RID: 74005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012115")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x0401468E RID: 83598
		[Token(Token = "0x401468E")]
		[FieldOffset(Offset = "0x10")]
		public bool isDead;

		// Token: 0x0401468F RID: 83599
		[Token(Token = "0x401468F")]
		[FieldOffset(Offset = "0x14")]
		public int hpRatio;

		// Token: 0x04014690 RID: 83600
		[Token(Token = "0x4014690")]
		[FieldOffset(Offset = "0x18")]
		public List<int> count;

		// Token: 0x04014691 RID: 83601
		[Token(Token = "0x4014691")]
		[FieldOffset(Offset = "0x20")]
		public int extraParam;

		// Token: 0x04014692 RID: 83602
		[Token(Token = "0x4014692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalNotCollected;

		// Token: 0x04014693 RID: 83603
		[Token(Token = "0x4014693")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_totalNotCollected;

		// Token: 0x04014694 RID: 83604
		[Token(Token = "0x4014694")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxStockCount;

		// Token: 0x04014695 RID: 83605
		[Token(Token = "0x4014695")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxStockCount;

		// Token: 0x04014696 RID: 83606
		[Token(Token = "0x4014696")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_droppedNotCollected;

		// Token: 0x04014697 RID: 83607
		[Token(Token = "0x4014697")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_droppedNotCollected;

		// Token: 0x04014698 RID: 83608
		[Token(Token = "0x4014698")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_statusHpRatio;

		// Token: 0x04014699 RID: 83609
		[Token(Token = "0x4014699")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_statusHpRatio;

		// Token: 0x0401469A RID: 83610
		[Token(Token = "0x401469A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x0401469B RID: 83611
		[Token(Token = "0x401469B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
