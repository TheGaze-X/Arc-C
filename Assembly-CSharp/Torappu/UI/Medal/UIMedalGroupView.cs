using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004947 RID: 18759
	[Token(Token = "0x2004947")]
	public class UIMedalGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C45E RID: 115806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45E")]
		[Address(RVA = "0x15C1A20", Offset = "0x15C0620", VA = "0x1815C1A20")]
		public void UpdateStatus(UIMedalGroupView.DIYOptions options)
		{
		}

		// Token: 0x0601C45F RID: 115807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45F")]
		[Address(RVA = "0x15C18F0", Offset = "0x15C04F0", VA = "0x1815C18F0")]
		public void UpdateStatus(UIMedalGroupView.GroupOptions options)
		{
		}

		// Token: 0x0601C460 RID: 115808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C460")]
		[Address(RVA = "0x15C1890", Offset = "0x15C0490", VA = "0x1815C1890")]
		public List<Graphic> GetGraphics()
		{
			return null;
		}

		// Token: 0x0601C461 RID: 115809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C461")]
		[Address(RVA = "0x15C2E10", Offset = "0x15C1A10", VA = "0x1815C2E10")]
		private void _UpdateDIY(UIMedalGroupView.DIYOptions options)
		{
		}

		// Token: 0x0601C462 RID: 115810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C462")]
		[Address(RVA = "0x15C3270", Offset = "0x15C1E70", VA = "0x1815C3270")]
		private void _UpdateGroup(UIMedalGroupView.GroupOptions options)
		{
		}

		// Token: 0x0601C463 RID: 115811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C463")]
		[Address(RVA = "0x15C1F10", Offset = "0x15C0B10", VA = "0x1815C1F10")]
		private void _LoadTokenConfigFromDIY(UIMedalGroupView.DIYViewCache viewCache, UIMedalDIYFrame frame)
		{
		}

		// Token: 0x0601C464 RID: 115812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C464")]
		[Address(RVA = "0x15C2890", Offset = "0x15C1490", VA = "0x1815C2890")]
		private void _LoadTokenConfigFromGroup(UIMedalGroupView.GroupViewCache viewCache, UIMedalGroupFrame frame)
		{
		}

		// Token: 0x0601C465 RID: 115813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C465")]
		[Address(RVA = "0x15C36A0", Offset = "0x15C22A0", VA = "0x1815C36A0")]
		private void _UpdateTokenViews()
		{
		}

		// Token: 0x0601C466 RID: 115814 RVA: 0x000A7BF8 File Offset: 0x000A5DF8
		[Token(Token = "0x601C466")]
		[Address(RVA = "0x15C1B50", Offset = "0x15C0750", VA = "0x1815C1B50")]
		private static bool _CheckIfMedalAchieved(string medalId, Func<string, bool> overrideCheckMethod)
		{
			return default(bool);
		}

		// Token: 0x0601C467 RID: 115815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C467")]
		[Address(RVA = "0x15C1D60", Offset = "0x15C0960", VA = "0x1815C1D60")]
		private static MedalPerData _LoadProperMedalData(string medalId, Func<string, bool> overrideCheckMethod)
		{
			return null;
		}

		// Token: 0x0601C468 RID: 115816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C468")]
		[Address(RVA = "0x15C1CB0", Offset = "0x15C08B0", VA = "0x1815C1CB0")]
		private static void _DestroyFrame(GameObject gameObject)
		{
		}

		// Token: 0x0601C469 RID: 115817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C469")]
		[Address(RVA = "0x15C1C00", Offset = "0x15C0800", VA = "0x1815C1C00")]
		private UIMedalGroupTokenView _CreateTokenView()
		{
			return null;
		}

		// Token: 0x0601C46A RID: 115818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C46A")]
		[Address(RVA = "0x15C2B80", Offset = "0x15C1780", VA = "0x1815C2B80")]
		private void _RecollectGraphics()
		{
		}

		// Token: 0x0601C46B RID: 115819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C46B")]
		[Address(RVA = "0x15C3AC0", Offset = "0x15C26C0", VA = "0x1815C3AC0")]
		public UIMedalGroupView()
		{
		}

		// Token: 0x04024FD4 RID: 151508
		[Token(Token = "0x4024FD4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Note the pivot should be on the left-bottom corner")]
		private RectTransform _frameContainer;

		// Token: 0x04024FD5 RID: 151509
		[Token(Token = "0x4024FD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _tokenContainer;

		// Token: 0x04024FD6 RID: 151510
		[Token(Token = "0x4024FD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIMedalGroupTokenView _tokePrefab;

		// Token: 0x04024FD7 RID: 151511
		[Token(Token = "0x4024FD7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _diyDefaultTokenBkg;

		// Token: 0x04024FD8 RID: 151512
		[Token(Token = "0x4024FD8")]
		[FieldOffset(Offset = "0x38")]
		private List<UIMedalGroupTokenView> m_tokenViews;

		// Token: 0x04024FD9 RID: 151513
		[Token(Token = "0x4024FD9")]
		[FieldOffset(Offset = "0x40")]
		private List<UIMedalGroupView.MedalConfig> m_tokenConfigs;

		// Token: 0x04024FDA RID: 151514
		[Token(Token = "0x4024FDA")]
		[FieldOffset(Offset = "0x48")]
		private List<UIMedalDIYFrame.MedalPosInfo> m_sharedDIYPosList;

		// Token: 0x04024FDB RID: 151515
		[Token(Token = "0x4024FDB")]
		[FieldOffset(Offset = "0x50")]
		private UIPage page;

		// Token: 0x04024FDC RID: 151516
		[Token(Token = "0x4024FDC")]
		[FieldOffset(Offset = "0x58")]
		private List<Graphic> m_graphics;

		// Token: 0x04024FDD RID: 151517
		[Token(Token = "0x4024FDD")]
		[FieldOffset(Offset = "0x60")]
		private UIMedalGroupView.DIYViewCache m_diyCache;

		// Token: 0x04024FDE RID: 151518
		[Token(Token = "0x4024FDE")]
		[FieldOffset(Offset = "0x90")]
		private UIMedalGroupView.GroupViewCache m_groupCache;

		// Token: 0x04024FDF RID: 151519
		[Token(Token = "0x4024FDF")]
		[FieldOffset(Offset = "0xA0")]
		private UIMedalDIYFrame m_diyFrame;

		// Token: 0x04024FE0 RID: 151520
		[Token(Token = "0x4024FE0")]
		[FieldOffset(Offset = "0xA8")]
		private UIMedalGroupFrame m_groupFrame;

		// Token: 0x04024FE1 RID: 151521
		[Token(Token = "0x4024FE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04024FE2 RID: 151522
		[Token(Token = "0x4024FE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_UpdateStatus;

		// Token: 0x04024FE3 RID: 151523
		[Token(Token = "0x4024FE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetGraphics;

		// Token: 0x04024FE4 RID: 151524
		[Token(Token = "0x4024FE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateDIY;

		// Token: 0x04024FE5 RID: 151525
		[Token(Token = "0x4024FE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateGroup;

		// Token: 0x04024FE6 RID: 151526
		[Token(Token = "0x4024FE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadTokenConfigFromDIY;

		// Token: 0x04024FE7 RID: 151527
		[Token(Token = "0x4024FE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadTokenConfigFromGroup;

		// Token: 0x04024FE8 RID: 151528
		[Token(Token = "0x4024FE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateTokenViews;

		// Token: 0x04024FE9 RID: 151529
		[Token(Token = "0x4024FE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfMedalAchieved;

		// Token: 0x04024FEA RID: 151530
		[Token(Token = "0x4024FEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadProperMedalData;

		// Token: 0x04024FEB RID: 151531
		[Token(Token = "0x4024FEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DestroyFrame;

		// Token: 0x04024FEC RID: 151532
		[Token(Token = "0x4024FEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateTokenView;

		// Token: 0x04024FED RID: 151533
		[Token(Token = "0x4024FED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RecollectGraphics;

		// Token: 0x04024FEE RID: 151534
		[Token(Token = "0x4024FEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004948 RID: 18760
		[Token(Token = "0x2004948")]
		public struct DIYOptions
		{
			// Token: 0x17004303 RID: 17155
			// (get) Token: 0x0601C46C RID: 115820 RVA: 0x000A7C10 File Offset: 0x000A5E10
			[Token(Token = "0x17004303")]
			public bool isEmpty
			{
				[Token(Token = "0x601C46C")]
				[Address(RVA = "0x15C4A70", Offset = "0x15C3670", VA = "0x1815C4A70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04024FEF RID: 151535
			[Token(Token = "0x4024FEF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalGroupView.DIYOptions EMPTY;

			// Token: 0x04024FF0 RID: 151536
			[Token(Token = "0x4024FF0")]
			[FieldOffset(Offset = "0x0")]
			public UIPage page;

			// Token: 0x04024FF1 RID: 151537
			[Token(Token = "0x4024FF1")]
			[FieldOffset(Offset = "0x8")]
			public string frameId;

			// Token: 0x04024FF2 RID: 151538
			[Token(Token = "0x4024FF2")]
			[FieldOffset(Offset = "0x10")]
			public IDictionary<string, HexPoint> positions;

			// Token: 0x04024FF3 RID: 151539
			[Token(Token = "0x4024FF3")]
			[FieldOffset(Offset = "0x18")]
			public bool usePool;

			// Token: 0x04024FF4 RID: 151540
			[Token(Token = "0x4024FF4")]
			[FieldOffset(Offset = "0x20")]
			public Sprite overrideTokenBkg;

			// Token: 0x04024FF5 RID: 151541
			[Token(Token = "0x4024FF5")]
			[FieldOffset(Offset = "0x28")]
			public Func<string, bool> overrideCheckIfAchieved;
		}

		// Token: 0x02004949 RID: 18761
		[Token(Token = "0x2004949")]
		public struct GroupOptions
		{
			// Token: 0x17004304 RID: 17156
			// (get) Token: 0x0601C46E RID: 115822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004304")]
			public string groupId
			{
				[Token(Token = "0x601C46E")]
				[Address(RVA = "0x15C52D0", Offset = "0x15C3ED0", VA = "0x1815C52D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004305 RID: 17157
			// (get) Token: 0x0601C46F RID: 115823 RVA: 0x000A7C28 File Offset: 0x000A5E28
			[Token(Token = "0x17004305")]
			public bool isEmpty
			{
				[Token(Token = "0x601C46F")]
				[Address(RVA = "0x15C5330", Offset = "0x15C3F30", VA = "0x1815C5330")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04024FF6 RID: 151542
			[Token(Token = "0x4024FF6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalGroupView.GroupOptions EMPTY;

			// Token: 0x04024FF7 RID: 151543
			[Token(Token = "0x4024FF7")]
			[FieldOffset(Offset = "0x0")]
			public UIPage page;

			// Token: 0x04024FF8 RID: 151544
			[Token(Token = "0x4024FF8")]
			[FieldOffset(Offset = "0x8")]
			public MedalGroupViewModel groupModel;

			// Token: 0x04024FF9 RID: 151545
			[Token(Token = "0x4024FF9")]
			[FieldOffset(Offset = "0x10")]
			public bool usePool;
		}

		// Token: 0x0200494A RID: 18762
		[Token(Token = "0x200494A")]
		public struct MedalConfig
		{
			// Token: 0x17004306 RID: 17158
			// (get) Token: 0x0601C471 RID: 115825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004306")]
			public string medalId
			{
				[Token(Token = "0x601C471")]
				[Address(RVA = "0x15C81E0", Offset = "0x15C6DE0", VA = "0x1815C81E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x04024FFA RID: 151546
			[Token(Token = "0x4024FFA")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x04024FFB RID: 151547
			[Token(Token = "0x4024FFB")]
			[FieldOffset(Offset = "0x8")]
			public Sprite medalBkg;

			// Token: 0x04024FFC RID: 151548
			[Token(Token = "0x4024FFC")]
			[FieldOffset(Offset = "0x10")]
			public MedalPerData data;
		}

		// Token: 0x0200494B RID: 18763
		[Token(Token = "0x200494B")]
		private struct DIYViewCache : IHotfixable
		{
			// Token: 0x17004307 RID: 17159
			// (get) Token: 0x0601C472 RID: 115826 RVA: 0x000A7C40 File Offset: 0x000A5E40
			[Token(Token = "0x17004307")]
			public bool isEmpty
			{
				[Token(Token = "0x601C472")]
				[Address(RVA = "0x15C5200", Offset = "0x15C3E00", VA = "0x1815C5200")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601C473 RID: 115827 RVA: 0x000A7C58 File Offset: 0x000A5E58
			[Token(Token = "0x601C473")]
			[Address(RVA = "0x15C4C70", Offset = "0x15C3870", VA = "0x1815C4C70")]
			public static bool HasChanged(UIMedalGroupView.DIYViewCache lhs, UIMedalGroupView.DIYViewCache rhs)
			{
				return default(bool);
			}

			// Token: 0x0601C474 RID: 115828 RVA: 0x000A7C70 File Offset: 0x000A5E70
			[Token(Token = "0x601C474")]
			[Address(RVA = "0x15C4AE0", Offset = "0x15C36E0", VA = "0x1815C4AE0")]
			public static UIMedalGroupView.DIYViewCache CreateCache(UIMedalGroupView.DIYOptions options)
			{
				return default(UIMedalGroupView.DIYViewCache);
			}

			// Token: 0x0601C475 RID: 115829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C475")]
			[Address(RVA = "0x15C4DC0", Offset = "0x15C39C0", VA = "0x1815C4DC0")]
			private static string _CreateMedalSign(IDictionary<string, HexPoint> medalInfo)
			{
				return null;
			}

			// Token: 0x04024FFD RID: 151549
			[Token(Token = "0x4024FFD")]
			[FieldOffset(Offset = "0x0")]
			public string frameId;

			// Token: 0x04024FFE RID: 151550
			[Token(Token = "0x4024FFE")]
			[FieldOffset(Offset = "0x8")]
			public string medalSign;

			// Token: 0x04024FFF RID: 151551
			[Token(Token = "0x4024FFF")]
			[FieldOffset(Offset = "0x10")]
			public List<MedalPerData> medalList;

			// Token: 0x04025000 RID: 151552
			[Token(Token = "0x4025000")]
			[FieldOffset(Offset = "0x18")]
			public IDictionary<string, HexPoint> positions;

			// Token: 0x04025001 RID: 151553
			[Token(Token = "0x4025001")]
			[FieldOffset(Offset = "0x20")]
			public Sprite tokenBkg;

			// Token: 0x04025002 RID: 151554
			[Token(Token = "0x4025002")]
			[FieldOffset(Offset = "0x28")]
			public Func<string, bool> overrideCheckIfAchieved;

			// Token: 0x04025003 RID: 151555
			[Token(Token = "0x4025003")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04025004 RID: 151556
			[Token(Token = "0x4025004")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HasChanged;

			// Token: 0x04025005 RID: 151557
			[Token(Token = "0x4025005")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CreateCache;

			// Token: 0x04025006 RID: 151558
			[Token(Token = "0x4025006")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CreateMedalSign;
		}

		// Token: 0x0200494C RID: 18764
		[Token(Token = "0x200494C")]
		private struct GroupViewCache
		{
			// Token: 0x0601C476 RID: 115830 RVA: 0x000A7C88 File Offset: 0x000A5E88
			[Token(Token = "0x601C476")]
			[Address(RVA = "0x15C5390", Offset = "0x15C3F90", VA = "0x1815C5390")]
			public static UIMedalGroupView.GroupViewCache CreateCache(UIMedalGroupView.GroupOptions options)
			{
				return default(UIMedalGroupView.GroupViewCache);
			}

			// Token: 0x04025007 RID: 151559
			[Token(Token = "0x4025007")]
			[FieldOffset(Offset = "0x0")]
			public MedalGroupViewModel groupModel;

			// Token: 0x04025008 RID: 151560
			[Token(Token = "0x4025008")]
			[FieldOffset(Offset = "0x8")]
			public UIPage page;
		}
	}
}
