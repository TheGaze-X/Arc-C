using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F9A RID: 16282
	[Token(Token = "0x2003F9A")]
	public class SiracusaMapMapNodeViewModel : ISiracusaMapStageInfoModel, IHotfixable
	{
		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x06019415 RID: 103445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019416 RID: 103446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C52")]
		public StageViewModel normalStage
		{
			[Token(Token = "0x6019415")]
			[Address(RVA = "0x11EE1F0", Offset = "0x11ECDF0", VA = "0x1811EE1F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019416")]
			[Address(RVA = "0x11EE670", Offset = "0x11ED270", VA = "0x1811EE670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x06019417 RID: 103447 RVA: 0x0009D5F0 File Offset: 0x0009B7F0
		// (set) Token: 0x06019418 RID: 103448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C53")]
		public int rankNum
		{
			[Token(Token = "0x6019417")]
			[Address(RVA = "0x11EE4F0", Offset = "0x11ED0F0", VA = "0x1811EE4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019418")]
			[Address(RVA = "0x11EE6F0", Offset = "0x11ED2F0", VA = "0x1811EE6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x06019419 RID: 103449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C54")]
		public string pointId
		{
			[Token(Token = "0x6019419")]
			[Address(RVA = "0x11EE370", Offset = "0x11ECF70", VA = "0x1811EE370", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0601941A RID: 103450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C55")]
		public string pointName
		{
			[Token(Token = "0x601941A")]
			[Address(RVA = "0x11EE460", Offset = "0x11ED060", VA = "0x1811EE460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0601941B RID: 103451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C56")]
		public string pointItaName
		{
			[Token(Token = "0x601941B")]
			[Address(RVA = "0x11EE3D0", Offset = "0x11ECFD0", VA = "0x1811EE3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0601941C RID: 103452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C57")]
		public string pointDesc
		{
			[Token(Token = "0x601941C")]
			[Address(RVA = "0x11EE250", Offset = "0x11ECE50", VA = "0x1811EE250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0601941D RID: 103453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C58")]
		public string pointIconId
		{
			[Token(Token = "0x601941D")]
			[Address(RVA = "0x11EE2E0", Offset = "0x11ECEE0", VA = "0x1811EE2E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0601941E RID: 103454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C59")]
		public string stageId
		{
			[Token(Token = "0x601941E")]
			[Address(RVA = "0x11EE550", Offset = "0x11ED150", VA = "0x1811EE550", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601941F RID: 103455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601941F")]
		[Address(RVA = "0x11EDED0", Offset = "0x11ECAD0", VA = "0x1811EDED0")]
		public void LoadData(SiracusaMapMapNodeViewModel.Param param)
		{
		}

		// Token: 0x06019420 RID: 103456 RVA: 0x0009D608 File Offset: 0x0009B808
		[Token(Token = "0x6019420")]
		[Address(RVA = "0x11EDC50", Offset = "0x11EC850", VA = "0x1811EDC50")]
		public bool IsSameNodeWithStatus(NodeModelStruct nodeModelStruct)
		{
			return default(bool);
		}

		// Token: 0x06019421 RID: 103457 RVA: 0x0009D620 File Offset: 0x0009B820
		[Token(Token = "0x6019421")]
		[Address(RVA = "0x11EDE70", Offset = "0x11ECA70", VA = "0x1811EDE70")]
		public bool IsTaskNode()
		{
			return default(bool);
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x0009D638 File Offset: 0x0009B838
		[Token(Token = "0x6019422")]
		[Address(RVA = "0x11EDBF0", Offset = "0x11EC7F0", VA = "0x1811EDBF0")]
		public bool IsNormalNode()
		{
			return default(bool);
		}

		// Token: 0x06019423 RID: 103459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019423")]
		[Address(RVA = "0x11EE190", Offset = "0x11ECD90", VA = "0x1811EE190")]
		public SiracusaMapMapNodeViewModel()
		{
		}

		// Token: 0x0401F58C RID: 128396
		[Token(Token = "0x401F58C")]
		[FieldOffset(Offset = "0x10")]
		public SiracusaMapMapNodeViewModel.NodeType nodeType;

		// Token: 0x0401F58D RID: 128397
		[Token(Token = "0x401F58D")]
		[FieldOffset(Offset = "0x18")]
		private SiracusaData.PointData m_pointData;

		// Token: 0x0401F58E RID: 128398
		[Token(Token = "0x401F58E")]
		[FieldOffset(Offset = "0x20")]
		public bool isStage;

		// Token: 0x0401F590 RID: 128400
		[Token(Token = "0x401F590")]
		[FieldOffset(Offset = "0x30")]
		public StageViewModel hardStage;

		// Token: 0x0401F591 RID: 128401
		[Token(Token = "0x401F591")]
		[FieldOffset(Offset = "0x38")]
		public string cornerIconId;

		// Token: 0x0401F592 RID: 128402
		[Token(Token = "0x401F592")]
		[FieldOffset(Offset = "0x40")]
		public bool isSelectingHard;

		// Token: 0x0401F594 RID: 128404
		[Token(Token = "0x401F594")]
		[FieldOffset(Offset = "0x48")]
		public SiracusaMapMapNodeViewModel.CharCardPatch charCardPatch;

		// Token: 0x0401F595 RID: 128405
		[Token(Token = "0x401F595")]
		[FieldOffset(Offset = "0x78")]
		public bool showSelected;

		// Token: 0x0401F596 RID: 128406
		[Token(Token = "0x401F596")]
		[FieldOffset(Offset = "0x80")]
		private string m_pointId;

		// Token: 0x0401F597 RID: 128407
		[Token(Token = "0x401F597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_normalStage;

		// Token: 0x0401F598 RID: 128408
		[Token(Token = "0x401F598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_normalStage;

		// Token: 0x0401F599 RID: 128409
		[Token(Token = "0x401F599")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rankNum;

		// Token: 0x0401F59A RID: 128410
		[Token(Token = "0x401F59A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_rankNum;

		// Token: 0x0401F59B RID: 128411
		[Token(Token = "0x401F59B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pointId;

		// Token: 0x0401F59C RID: 128412
		[Token(Token = "0x401F59C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pointName;

		// Token: 0x0401F59D RID: 128413
		[Token(Token = "0x401F59D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_pointItaName;

		// Token: 0x0401F59E RID: 128414
		[Token(Token = "0x401F59E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_pointDesc;

		// Token: 0x0401F59F RID: 128415
		[Token(Token = "0x401F59F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_pointIconId;

		// Token: 0x0401F5A0 RID: 128416
		[Token(Token = "0x401F5A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401F5A1 RID: 128417
		[Token(Token = "0x401F5A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401F5A2 RID: 128418
		[Token(Token = "0x401F5A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsSameNodeWithStatus;

		// Token: 0x0401F5A3 RID: 128419
		[Token(Token = "0x401F5A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsTaskNode;

		// Token: 0x0401F5A4 RID: 128420
		[Token(Token = "0x401F5A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsNormalNode;

		// Token: 0x0401F5A5 RID: 128421
		[Token(Token = "0x401F5A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F9B RID: 16283
		[Token(Token = "0x2003F9B")]
		public enum NodeType
		{
			// Token: 0x0401F5A7 RID: 128423
			[Token(Token = "0x401F5A7")]
			NONE,
			// Token: 0x0401F5A8 RID: 128424
			[Token(Token = "0x401F5A8")]
			NORMAL,
			// Token: 0x0401F5A9 RID: 128425
			[Token(Token = "0x401F5A9")]
			TASK
		}

		// Token: 0x02003F9C RID: 16284
		[Token(Token = "0x2003F9C")]
		public struct Param
		{
			// Token: 0x0401F5AA RID: 128426
			[Token(Token = "0x401F5AA")]
			[FieldOffset(Offset = "0x0")]
			public string pointId;

			// Token: 0x0401F5AB RID: 128427
			[Token(Token = "0x401F5AB")]
			[FieldOffset(Offset = "0x8")]
			public SiracusaData.PointData pointData;

			// Token: 0x0401F5AC RID: 128428
			[Token(Token = "0x401F5AC")]
			[FieldOffset(Offset = "0x10")]
			public SiracusaMapMapNodeViewModel.CharCardPatch charCardPatch;

			// Token: 0x0401F5AD RID: 128429
			[Token(Token = "0x401F5AD")]
			[FieldOffset(Offset = "0x40")]
			public SiracusaMapStageInfoViewModel stageInfoViewModel;

			// Token: 0x0401F5AE RID: 128430
			[Token(Token = "0x401F5AE")]
			[FieldOffset(Offset = "0x48")]
			public string cornerIconId;
		}

		// Token: 0x02003F9D RID: 16285
		[Token(Token = "0x2003F9D")]
		public struct CharCardPatch : IHotfixable
		{
			// Token: 0x06019424 RID: 103460 RVA: 0x0009D650 File Offset: 0x0009B850
			[Token(Token = "0x6019424")]
			[Address(RVA = "0x11DF6C0", Offset = "0x11DE2C0", VA = "0x1811DF6C0")]
			public bool IsEqual(SiracusaMapMapNodeViewModel.CharCardPatch cardPatch)
			{
				return default(bool);
			}

			// Token: 0x0401F5AF RID: 128431
			[Token(Token = "0x401F5AF")]
			[FieldOffset(Offset = "0x0")]
			public string charCardId;

			// Token: 0x0401F5B0 RID: 128432
			[Token(Token = "0x401F5B0")]
			[FieldOffset(Offset = "0x8")]
			public Color charCardColor;

			// Token: 0x0401F5B1 RID: 128433
			[Token(Token = "0x401F5B1")]
			[FieldOffset(Offset = "0x18")]
			public string taskCharId;

			// Token: 0x0401F5B2 RID: 128434
			[Token(Token = "0x401F5B2")]
			[FieldOffset(Offset = "0x20")]
			public string taskId;

			// Token: 0x0401F5B3 RID: 128435
			[Token(Token = "0x401F5B3")]
			[FieldOffset(Offset = "0x28")]
			public string taskRingId;

			// Token: 0x0401F5B4 RID: 128436
			[Token(Token = "0x401F5B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEqual;
		}
	}
}
