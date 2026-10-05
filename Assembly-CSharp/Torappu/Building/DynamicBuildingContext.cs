using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017C6 RID: 6086
	[Token(Token = "0x20017C6")]
	public class DynamicBuildingContext : IBuildingContext, IHotfixable, ITimeWatcher, IRefCountInstance
	{
		// Token: 0x0600999A RID: 39322 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		[Token(Token = "0x600999A")]
		[Address(RVA = "0x31421A0", Offset = "0x3140DA0", VA = "0x1831421A0", Slot = "10")]
		public long GetInstSignature()
		{
			return 0L;
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999B")]
		[Address(RVA = "0x3142290", Offset = "0x3140E90", VA = "0x183142290", Slot = "8")]
		public void Retain()
		{
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999C")]
		[Address(RVA = "0x3142220", Offset = "0x3140E20", VA = "0x183142220", Slot = "9")]
		public void Release()
		{
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999D")]
		[Address(RVA = "0x31420F0", Offset = "0x3140CF0", VA = "0x1831420F0")]
		public void Clear()
		{
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999E")]
		[Address(RVA = "0x3142390", Offset = "0x3140F90", VA = "0x183142390", Slot = "7")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001091")]
		public BuildingModel model
		{
			[Token(Token = "0x600999F")]
			[Address(RVA = "0x3142720", Offset = "0x3141320", VA = "0x183142720", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001092")]
		public BuildingServiceController service
		{
			[Token(Token = "0x60099A0")]
			[Address(RVA = "0x3142780", Offset = "0x3141380", VA = "0x183142780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060099A1 RID: 39329 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		[Token(Token = "0x17001093")]
		public bool isEmpty
		{
			[Token(Token = "0x60099A1")]
			[Address(RVA = "0x3142690", Offset = "0x3141290", VA = "0x183142690", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A2")]
		[Address(RVA = "0x3142410", Offset = "0x3141010", VA = "0x183142410")]
		private void _CreateInst()
		{
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A3")]
		[Address(RVA = "0x31425E0", Offset = "0x31411E0", VA = "0x1831425E0")]
		public DynamicBuildingContext()
		{
		}

		// Token: 0x0400901A RID: 36890
		[Token(Token = "0x400901A")]
		[FieldOffset(Offset = "0x10")]
		private int m_refCount;

		// Token: 0x0400901B RID: 36891
		[Token(Token = "0x400901B")]
		[FieldOffset(Offset = "0x18")]
		private DynamicBuildingContext.Content m_content;

		// Token: 0x0400901C RID: 36892
		[Token(Token = "0x400901C")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInitRetain;

		// Token: 0x0400901D RID: 36893
		[Token(Token = "0x400901D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetInstSignature;

		// Token: 0x0400901E RID: 36894
		[Token(Token = "0x400901E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Retain;

		// Token: 0x0400901F RID: 36895
		[Token(Token = "0x400901F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Release;

		// Token: 0x04009020 RID: 36896
		[Token(Token = "0x4009020")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04009021 RID: 36897
		[Token(Token = "0x4009021")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04009022 RID: 36898
		[Token(Token = "0x4009022")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x04009023 RID: 36899
		[Token(Token = "0x4009023")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_service;

		// Token: 0x04009024 RID: 36900
		[Token(Token = "0x4009024")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04009025 RID: 36901
		[Token(Token = "0x4009025")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateInst;

		// Token: 0x04009026 RID: 36902
		[Token(Token = "0x4009026")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020017C7 RID: 6087
		[Token(Token = "0x20017C7")]
		private struct Content
		{
			// Token: 0x060099A5 RID: 39333 RVA: 0x0003BAF0 File Offset: 0x00039CF0
			[Token(Token = "0x60099A5")]
			[Address(RVA = "0x31420D0", Offset = "0x3140CD0", VA = "0x1831420D0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04009027 RID: 36903
			[Token(Token = "0x4009027")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DynamicBuildingContext.Content EMPTY;

			// Token: 0x04009028 RID: 36904
			[Token(Token = "0x4009028")]
			[FieldOffset(Offset = "0x0")]
			public BuildingModel model;

			// Token: 0x04009029 RID: 36905
			[Token(Token = "0x4009029")]
			[FieldOffset(Offset = "0x8")]
			public BuildingServiceController service;
		}
	}
}
