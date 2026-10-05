using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004058 RID: 16472
	[Token(Token = "0x2004058")]
	public class SandboxV2LogisticsCharSelectViewModel : IHotfixable
	{
		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x060197A8 RID: 104360 RVA: 0x0009E3D0 File Offset: 0x0009C5D0
		[Token(Token = "0x17003CA8")]
		public bool isValid
		{
			[Token(Token = "0x60197A8")]
			[Address(RVA = "0x123FA30", Offset = "0x123E630", VA = "0x18123FA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x060197A9 RID: 104361 RVA: 0x0009E3E8 File Offset: 0x0009C5E8
		[Token(Token = "0x17003CA9")]
		public int duration
		{
			[Token(Token = "0x60197A9")]
			[Address(RVA = "0x123F9D0", Offset = "0x123E5D0", VA = "0x18123F9D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x060197AA RID: 104362 RVA: 0x0009E400 File Offset: 0x0009C600
		[Token(Token = "0x17003CAA")]
		public int drinkCapacity
		{
			[Token(Token = "0x60197AA")]
			[Address(RVA = "0x123F970", Offset = "0x123E570", VA = "0x18123F970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060197AB RID: 104363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197AB")]
		[Address(RVA = "0x123EDE0", Offset = "0x123D9E0", VA = "0x18123EDE0")]
		public void LoadData(string topicId, List<SandboxV2CharViewModel> selectedCharViewModels)
		{
		}

		// Token: 0x060197AC RID: 104364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197AC")]
		[Address(RVA = "0x123EF50", Offset = "0x123DB50", VA = "0x18123EF50")]
		public void RefreshData(string topicId)
		{
		}

		// Token: 0x060197AD RID: 104365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197AD")]
		[Address(RVA = "0x123F060", Offset = "0x123DC60", VA = "0x18123F060")]
		public void UpdateDataWithSingleChar(SandboxV2CharViewModel charViewModel, bool isAdd)
		{
		}

		// Token: 0x060197AE RID: 104366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197AE")]
		[Address(RVA = "0x123ECA0", Offset = "0x123D8A0", VA = "0x18123ECA0")]
		public void ClearAllBuff()
		{
		}

		// Token: 0x060197AF RID: 104367 RVA: 0x0009E418 File Offset: 0x0009C618
		[Token(Token = "0x60197AF")]
		[Address(RVA = "0x123EFF0", Offset = "0x123DBF0", VA = "0x18123EFF0")]
		public int TryToConsumeAimedBuffIndex()
		{
			return 0;
		}

		// Token: 0x060197B0 RID: 104368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B0")]
		[Address(RVA = "0x123F380", Offset = "0x123DF80", VA = "0x18123F380")]
		private void _GeneBuffDict(SandboxV2Data sandboxV2Data, List<SandboxV2CharViewModel> selectedCharViewModels)
		{
		}

		// Token: 0x060197B1 RID: 104369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197B1")]
		[Address(RVA = "0x123F8B0", Offset = "0x123E4B0", VA = "0x18123F8B0")]
		public SandboxV2LogisticsCharSelectViewModel()
		{
		}

		// Token: 0x0401FC13 RID: 130067
		[Token(Token = "0x401FC13")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isValid;

		// Token: 0x0401FC14 RID: 130068
		[Token(Token = "0x401FC14")]
		[FieldOffset(Offset = "0x14")]
		private int m_duration;

		// Token: 0x0401FC15 RID: 130069
		[Token(Token = "0x401FC15")]
		[FieldOffset(Offset = "0x18")]
		private int m_drinkCapacity;

		// Token: 0x0401FC16 RID: 130070
		[Token(Token = "0x401FC16")]
		[FieldOffset(Offset = "0x1C")]
		private int m_aimedBuffIndex;

		// Token: 0x0401FC17 RID: 130071
		[Token(Token = "0x401FC17")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, SandboxV2LogisticsCharSelectBuffViewModel> buffDict;

		// Token: 0x0401FC18 RID: 130072
		[Token(Token = "0x401FC18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0401FC19 RID: 130073
		[Token(Token = "0x401FC19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_duration;

		// Token: 0x0401FC1A RID: 130074
		[Token(Token = "0x401FC1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_drinkCapacity;

		// Token: 0x0401FC1B RID: 130075
		[Token(Token = "0x401FC1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401FC1C RID: 130076
		[Token(Token = "0x401FC1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401FC1D RID: 130077
		[Token(Token = "0x401FC1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateDataWithSingleChar;

		// Token: 0x0401FC1E RID: 130078
		[Token(Token = "0x401FC1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearAllBuff;

		// Token: 0x0401FC1F RID: 130079
		[Token(Token = "0x401FC1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryToConsumeAimedBuffIndex;

		// Token: 0x0401FC20 RID: 130080
		[Token(Token = "0x401FC20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneBuffDict;

		// Token: 0x0401FC21 RID: 130081
		[Token(Token = "0x401FC21")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
