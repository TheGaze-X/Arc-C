using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CA RID: 9418
	[Token(Token = "0x20024CA")]
	public class CrossTileRangeWithDist : CrossTileRange
	{
		// Token: 0x0600F26B RID: 62059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F26B")]
		[Address(RVA = "0x68A920", Offset = "0x689520", VA = "0x18068A920", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x00059448 File Offset: 0x00057648
		[Token(Token = "0x600F26C")]
		[Address(RVA = "0x68AAC0", Offset = "0x6896C0", VA = "0x18068AAC0", Slot = "17")]
		protected override bool VerifyTargetInternal(Entity unit, ReusableList<Entity> candidates, TargetOptions options, Func<Entity, bool> validator)
		{
			return default(bool);
		}

		// Token: 0x0600F26D RID: 62061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F26D")]
		[Address(RVA = "0x68B110", Offset = "0x689D10", VA = "0x18068B110")]
		public CrossTileRangeWithDist()
		{
		}

		// Token: 0x0600F26E RID: 62062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F26E")]
		[Address(RVA = "0x68A9D0", Offset = "0x6895D0", VA = "0x18068A9D0")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00059460 File Offset: 0x00057660
		[Token(Token = "0x600F26F")]
		[Address(RVA = "0x68AA50", Offset = "0x689650", VA = "0x18068AA50")]
		private bool <>xLuaBaseProxy_VerifyTargetInternal(Entity P0, ReusableList<Entity> P1, TargetOptions P2, Func<Entity, bool> P3)
		{
			return default(bool);
		}

		// Token: 0x04010C54 RID: 68692
		[Token(Token = "0x4010C54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxDist;

		// Token: 0x04010C55 RID: 68693
		[Token(Token = "0x4010C55")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _checkDirectDist;

		// Token: 0x04010C56 RID: 68694
		[Token(Token = "0x4010C56")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _checkDirection;

		// Token: 0x04010C57 RID: 68695
		[Token(Token = "0x4010C57")]
		[FieldOffset(Offset = "0x38")]
		private TargetSelector m_selector;

		// Token: 0x04010C58 RID: 68696
		[Token(Token = "0x4010C58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C59 RID: 68697
		[Token(Token = "0x4010C59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_VerifyTargetInternal;

		// Token: 0x04010C5A RID: 68698
		[Token(Token = "0x4010C5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
