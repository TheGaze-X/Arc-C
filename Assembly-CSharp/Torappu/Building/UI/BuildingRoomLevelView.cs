using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B33 RID: 6963
	[Token(Token = "0x2001B33")]
	public class BuildingRoomLevelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x00043410 File Offset: 0x00041610
		// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014C1")]
		public Color overrideMainColor
		{
			[Token(Token = "0x600AF47")]
			[Address(RVA = "0x32A62A0", Offset = "0x32A4EA0", VA = "0x1832A62A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600AF48")]
			[Address(RVA = "0x32A6530", Offset = "0x32A5130", VA = "0x1832A6530")]
			set
			{
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x00043428 File Offset: 0x00041628
		[Token(Token = "0x170014C2")]
		public Color mainColor
		{
			[Token(Token = "0x600AF49")]
			[Address(RVA = "0x32A6110", Offset = "0x32A4D10", VA = "0x1832A6110")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014C3")]
		public Image overrideIcon
		{
			[Token(Token = "0x600AF4A")]
			[Address(RVA = "0x32A6230", Offset = "0x32A4E30", VA = "0x1832A6230")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AF4B")]
			[Address(RVA = "0x32A6490", Offset = "0x32A5090", VA = "0x1832A6490")]
			set
			{
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C4")]
		public Image iconPrefab
		{
			[Token(Token = "0x600AF4C")]
			[Address(RVA = "0x32A5FE0", Offset = "0x32A4BE0", VA = "0x1832A5FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600AF4D RID: 44877 RVA: 0x00043440 File Offset: 0x00041640
		// (set) Token: 0x0600AF4E RID: 44878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014C5")]
		public int maxLevel
		{
			[Token(Token = "0x600AF4D")]
			[Address(RVA = "0x32A61C0", Offset = "0x32A4DC0", VA = "0x1832A61C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AF4E")]
			[Address(RVA = "0x32A63E0", Offset = "0x32A4FE0", VA = "0x1832A63E0")]
			set
			{
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600AF4F RID: 44879 RVA: 0x00043458 File Offset: 0x00041658
		// (set) Token: 0x0600AF50 RID: 44880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014C6")]
		public int level
		{
			[Token(Token = "0x600AF4F")]
			[Address(RVA = "0x32A60A0", Offset = "0x32A4CA0", VA = "0x1832A60A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AF50")]
			[Address(RVA = "0x32A6340", Offset = "0x32A4F40", VA = "0x1832A6340")]
			set
			{
			}
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF51")]
		[Address(RVA = "0x32A5CA0", Offset = "0x32A48A0", VA = "0x1832A5CA0")]
		public void SetLevel(int level, int maxLevel)
		{
		}

		// Token: 0x0600AF52 RID: 44882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF52")]
		[Address(RVA = "0x32A5D70", Offset = "0x32A4970", VA = "0x1832A5D70")]
		private void _UpdateContent()
		{
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF53")]
		[Address(RVA = "0x32A5F60", Offset = "0x32A4B60", VA = "0x1832A5F60")]
		public BuildingRoomLevelView()
		{
		}

		// Token: 0x0400A8C8 RID: 43208
		[Token(Token = "0x400A8C8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color INACTIVE_COLOR;

		// Token: 0x0400A8C9 RID: 43209
		[Token(Token = "0x400A8C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Note that this container's prefab would be override")]
		private SimpleLayoutContent _levelContainer;

		// Token: 0x0400A8CA RID: 43210
		[Token(Token = "0x400A8CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _mainColor;

		// Token: 0x0400A8CB RID: 43211
		[Token(Token = "0x400A8CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _showMaxLevel;

		// Token: 0x0400A8CC RID: 43212
		[Token(Token = "0x400A8CC")]
		[FieldOffset(Offset = "0x34")]
		private int m_maxLevel;

		// Token: 0x0400A8CD RID: 43213
		[Token(Token = "0x400A8CD")]
		[FieldOffset(Offset = "0x38")]
		private int m_level;

		// Token: 0x0400A8CE RID: 43214
		[Token(Token = "0x400A8CE")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x0400A8CF RID: 43215
		[Token(Token = "0x400A8CF")]
		[FieldOffset(Offset = "0x40")]
		private BuildingRoomLevelView.LevelAdapter m_adapter;

		// Token: 0x0400A8D0 RID: 43216
		[Token(Token = "0x400A8D0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isColorOverrided;

		// Token: 0x0400A8D1 RID: 43217
		[Token(Token = "0x400A8D1")]
		[FieldOffset(Offset = "0x4C")]
		private Color m_overrideMainColor;

		// Token: 0x0400A8D2 RID: 43218
		[Token(Token = "0x400A8D2")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_isIconOverrided;

		// Token: 0x0400A8D3 RID: 43219
		[Token(Token = "0x400A8D3")]
		[FieldOffset(Offset = "0x60")]
		private Image m_overrideIcon;

		// Token: 0x0400A8D4 RID: 43220
		[Token(Token = "0x400A8D4")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isViewConfigDirty;

		// Token: 0x0400A8D5 RID: 43221
		[Token(Token = "0x400A8D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_overrideMainColor;

		// Token: 0x0400A8D6 RID: 43222
		[Token(Token = "0x400A8D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_overrideMainColor;

		// Token: 0x0400A8D7 RID: 43223
		[Token(Token = "0x400A8D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mainColor;

		// Token: 0x0400A8D8 RID: 43224
		[Token(Token = "0x400A8D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_overrideIcon;

		// Token: 0x0400A8D9 RID: 43225
		[Token(Token = "0x400A8D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_overrideIcon;

		// Token: 0x0400A8DA RID: 43226
		[Token(Token = "0x400A8DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_iconPrefab;

		// Token: 0x0400A8DB RID: 43227
		[Token(Token = "0x400A8DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x0400A8DC RID: 43228
		[Token(Token = "0x400A8DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_maxLevel;

		// Token: 0x0400A8DD RID: 43229
		[Token(Token = "0x400A8DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0400A8DE RID: 43230
		[Token(Token = "0x400A8DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0400A8DF RID: 43231
		[Token(Token = "0x400A8DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetLevel;

		// Token: 0x0400A8E0 RID: 43232
		[Token(Token = "0x400A8E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A8E1 RID: 43233
		[Token(Token = "0x400A8E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B34 RID: 6964
		[Token(Token = "0x2001B34")]
		private class LevelAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AF55 RID: 44885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF55")]
			[Address(RVA = "0x32ABFC0", Offset = "0x32AABC0", VA = "0x1832ABFC0")]
			public LevelAdapter(BuildingRoomLevelView closure)
			{
			}

			// Token: 0x170014C7 RID: 5319
			// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x00043470 File Offset: 0x00041670
			[Token(Token = "0x170014C7")]
			public override int count
			{
				[Token(Token = "0x600AF56")]
				[Address(RVA = "0x32AC040", Offset = "0x32AAC40", VA = "0x1832AC040", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AF57 RID: 44887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF57")]
			[Address(RVA = "0x32ABC70", Offset = "0x32AA870", VA = "0x1832ABC70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A8E2 RID: 43234
			[Token(Token = "0x400A8E2")]
			[FieldOffset(Offset = "0x20")]
			private BuildingRoomLevelView m_closure;

			// Token: 0x0400A8E3 RID: 43235
			[Token(Token = "0x400A8E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A8E4 RID: 43236
			[Token(Token = "0x400A8E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A8E5 RID: 43237
			[Token(Token = "0x400A8E5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
