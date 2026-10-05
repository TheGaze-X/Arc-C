using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB6 RID: 6838
	[Token(Token = "0x2001AB6")]
	public abstract class BOutputRoom : BRoom
	{
		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x00042900 File Offset: 0x00040B00
		// (set) Token: 0x0600AC97 RID: 44183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700146A")]
		[Inspect]
		protected Color mainColor
		{
			[Token(Token = "0x600AC96")]
			[Address(RVA = "0x3273350", Offset = "0x3271F50", VA = "0x183273350")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600AC97")]
			[Address(RVA = "0x32735D0", Offset = "0x32721D0", VA = "0x1832735D0")]
			set
			{
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x0600AC98 RID: 44184 RVA: 0x00042918 File Offset: 0x00040B18
		[Token(Token = "0x1700146B")]
		protected Color normalColor
		{
			[Token(Token = "0x600AC98")]
			[Address(RVA = "0x32733D0", Offset = "0x3271FD0", VA = "0x1832733D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x00042930 File Offset: 0x00040B30
		[Token(Token = "0x1700146C")]
		protected Color hilightColor
		{
			[Token(Token = "0x600AC99")]
			[Address(RVA = "0x3273260", Offset = "0x3271E60", VA = "0x183273260")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x0600AC9A RID: 44186
		[Token(Token = "0x1700146D")]
		protected abstract bool isWorking { [Token(Token = "0x600AC9A")] get; }

		// Token: 0x0600AC9B RID: 44187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9B")]
		[Address(RVA = "0x3272680", Offset = "0x3271280", VA = "0x183272680", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9C")]
		[Address(RVA = "0x3272890", Offset = "0x3271490", VA = "0x183272890", Slot = "8")]
		protected override void OnRoomDestroy()
		{
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9D")]
		[Address(RVA = "0x3272550", Offset = "0x3271150", VA = "0x183272550", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9E")]
		[Address(RVA = "0x3272DB0", Offset = "0x32719B0", VA = "0x183272DB0", Slot = "12")]
		protected virtual void UpdateRoomContent(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600AC9F RID: 44191 RVA: 0x00042948 File Offset: 0x00040B48
		// (set) Token: 0x0600ACA0 RID: 44192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700146E")]
		protected bool isHighlight
		{
			[Token(Token = "0x600AC9F")]
			[Address(RVA = "0x32732E0", Offset = "0x3271EE0", VA = "0x1832732E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ACA0")]
			[Address(RVA = "0x3273550", Offset = "0x3272150", VA = "0x183273550")]
			set
			{
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700146F")]
		protected string roomStateDesc
		{
			[Token(Token = "0x600ACA1")]
			[Address(RVA = "0x32734C0", Offset = "0x32720C0", VA = "0x1832734C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ACA2")]
			[Address(RVA = "0x3273820", Offset = "0x3272420", VA = "0x183273820")]
			set
			{
			}
		}

		// Token: 0x17001470 RID: 5232
		// (set) Token: 0x0600ACA3 RID: 44195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001470")]
		protected Color roomStateColor
		{
			[Token(Token = "0x600ACA3")]
			[Address(RVA = "0x3273770", Offset = "0x3272370", VA = "0x183273770")]
			set
			{
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x00042960 File Offset: 0x00040B60
		// (set) Token: 0x0600ACA5 RID: 44197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001471")]
		protected float roomProgress
		{
			[Token(Token = "0x600ACA4")]
			[Address(RVA = "0x3273450", Offset = "0x3272050", VA = "0x183273450")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600ACA5")]
			[Address(RVA = "0x32736E0", Offset = "0x32722E0", VA = "0x1832736E0")]
			set
			{
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x00042978 File Offset: 0x00040B78
		[Token(Token = "0x17001472")]
		protected virtual bool isHarvestable
		{
			[Token(Token = "0x600ACA6")]
			[Address(RVA = "0x3271350", Offset = "0x326FF50", VA = "0x183271350", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001473")]
		protected virtual GameObject harvestIcon
		{
			[Token(Token = "0x600ACA7")]
			[Address(RVA = "0x32712F0", Offset = "0x326FEF0", VA = "0x1832712F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA8")]
		[Address(RVA = "0x3271250", Offset = "0x326FE50", VA = "0x183271250", Slot = "15")]
		protected virtual void TriggerSettleEffect(BuildingUIResMenu.AsyncSettleInfo settleInfo, Action<BuildingUIResMenu.AsyncSettleInfo> triggerFunc)
		{
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA9")]
		[Address(RVA = "0x3272940", Offset = "0x3271540", VA = "0x183272940", Slot = "16")]
		protected virtual void OnWorkStateUpdated(bool working)
		{
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACAA")]
		[Address(RVA = "0x32721C0", Offset = "0x3270DC0", VA = "0x1832721C0")]
		public void NotifySettleEffect()
		{
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x00042990 File Offset: 0x00040B90
		[Token(Token = "0x600ACAB")]
		[Address(RVA = "0x3272BD0", Offset = "0x32717D0", VA = "0x183272BD0")]
		public Vector2 RoomIconAnchor()
		{
			return default(Vector2);
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACAC")]
		[Address(RVA = "0x3273070", Offset = "0x3271C70", VA = "0x183273070")]
		private void _SetStateDescHilight(bool isHilight)
		{
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACAD")]
		[Address(RVA = "0x32731B0", Offset = "0x3271DB0", VA = "0x1832731B0")]
		protected BOutputRoom()
		{
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACAF")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB0")]
		[Address(RVA = "0x326BF00", Offset = "0x326AB00", VA = "0x18326BF00")]
		private void <>xLuaBaseProxy_OnRoomDestroy()
		{
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB1")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0400A4C0 RID: 42176
		[Token(Token = "0x400A4C0")]
		private const float EFFECT_WORK_ANIM_DUR = 2f;

		// Token: 0x0400A4C1 RID: 42177
		[Token(Token = "0x400A4C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRoomState;

		// Token: 0x0400A4C2 RID: 42178
		[Token(Token = "0x400A4C2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Color used when the state desc is hilighted")]
		private Color _stateHilightColor;

		// Token: 0x0400A4C3 RID: 42179
		[Token(Token = "0x400A4C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Color used when the state desc is normal")]
		private Color _stateNormalColor;

		// Token: 0x0400A4C4 RID: 42180
		[Token(Token = "0x400A4C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BStationViewForProgressRoom _stationView;

		// Token: 0x0400A4C5 RID: 42181
		[Token(Token = "0x400A4C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _levelView;

		// Token: 0x0400A4C6 RID: 42182
		[Token(Token = "0x400A4C6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _highlightView;

		// Token: 0x0400A4C7 RID: 42183
		[Token(Token = "0x400A4C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("The theme color for an output room could be changed, add colored components here")]
		private UIColorGraphic _mainColorComponents;

		// Token: 0x0400A4C8 RID: 42184
		[Token(Token = "0x400A4C8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private Color _mainColor;

		// Token: 0x0400A4C9 RID: 42185
		[Token(Token = "0x400A4C9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private PiecewiseProgressBar _progressBar;

		// Token: 0x0400A4CA RID: 42186
		[Token(Token = "0x400A4CA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private PiecewiseProgressBar _effectWorking;

		// Token: 0x0400A4CB RID: 42187
		[Token(Token = "0x400A4CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textRoomCategory;

		// Token: 0x0400A4CC RID: 42188
		[Token(Token = "0x400A4CC")]
		[FieldOffset(Offset = "0xC0")]
		private BRoomLevelAdapter m_levelAdapter;

		// Token: 0x0400A4CD RID: 42189
		[Token(Token = "0x400A4CD")]
		[FieldOffset(Offset = "0xC8")]
		private BStationInfoModel m_stationModel;

		// Token: 0x0400A4CE RID: 42190
		[Token(Token = "0x400A4CE")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isStateHilight;

		// Token: 0x0400A4CF RID: 42191
		[Token(Token = "0x400A4CF")]
		[FieldOffset(Offset = "0xDC")]
		private Color m_stateDescColorCache;

		// Token: 0x0400A4D0 RID: 42192
		[Token(Token = "0x400A4D0")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_effectWorkTween;

		// Token: 0x0400A4D1 RID: 42193
		[Token(Token = "0x400A4D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainColor;

		// Token: 0x0400A4D2 RID: 42194
		[Token(Token = "0x400A4D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mainColor;

		// Token: 0x0400A4D3 RID: 42195
		[Token(Token = "0x400A4D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_normalColor;

		// Token: 0x0400A4D4 RID: 42196
		[Token(Token = "0x400A4D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hilightColor;

		// Token: 0x0400A4D5 RID: 42197
		[Token(Token = "0x400A4D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4D6 RID: 42198
		[Token(Token = "0x400A4D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRoomDestroy;

		// Token: 0x0400A4D7 RID: 42199
		[Token(Token = "0x400A4D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A4D8 RID: 42200
		[Token(Token = "0x400A4D8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateRoomContent;

		// Token: 0x0400A4D9 RID: 42201
		[Token(Token = "0x400A4D9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isHighlight;

		// Token: 0x0400A4DA RID: 42202
		[Token(Token = "0x400A4DA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isHighlight;

		// Token: 0x0400A4DB RID: 42203
		[Token(Token = "0x400A4DB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_roomStateDesc;

		// Token: 0x0400A4DC RID: 42204
		[Token(Token = "0x400A4DC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_roomStateDesc;

		// Token: 0x0400A4DD RID: 42205
		[Token(Token = "0x400A4DD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_roomStateColor;

		// Token: 0x0400A4DE RID: 42206
		[Token(Token = "0x400A4DE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_roomProgress;

		// Token: 0x0400A4DF RID: 42207
		[Token(Token = "0x400A4DF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_roomProgress;

		// Token: 0x0400A4E0 RID: 42208
		[Token(Token = "0x400A4E0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isHarvestable;

		// Token: 0x0400A4E1 RID: 42209
		[Token(Token = "0x400A4E1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_harvestIcon;

		// Token: 0x0400A4E2 RID: 42210
		[Token(Token = "0x400A4E2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TriggerSettleEffect;

		// Token: 0x0400A4E3 RID: 42211
		[Token(Token = "0x400A4E3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnWorkStateUpdated;

		// Token: 0x0400A4E4 RID: 42212
		[Token(Token = "0x400A4E4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_NotifySettleEffect;

		// Token: 0x0400A4E5 RID: 42213
		[Token(Token = "0x400A4E5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RoomIconAnchor;

		// Token: 0x0400A4E6 RID: 42214
		[Token(Token = "0x400A4E6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SetStateDescHilight;

		// Token: 0x0400A4E7 RID: 42215
		[Token(Token = "0x400A4E7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
