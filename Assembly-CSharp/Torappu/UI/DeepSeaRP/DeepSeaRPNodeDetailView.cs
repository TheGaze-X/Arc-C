using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200516D RID: 20845
	[Token(Token = "0x200516D")]
	public class DeepSeaRPNodeDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0601ECC8 RID: 126152 RVA: 0x000AFCE0 File Offset: 0x000ADEE0
		// (set) Token: 0x0601ECC9 RID: 126153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047BB")]
		public DeepSeaRPNodeDetailView.IntroStep status
		{
			[Token(Token = "0x601ECC8")]
			[Address(RVA = "0x1870770", Offset = "0x186F370", VA = "0x181870770")]
			[CompilerGenerated]
			get
			{
				return DeepSeaRPNodeDetailView.IntroStep.IDLE;
			}
			[Token(Token = "0x601ECC9")]
			[Address(RVA = "0x18708D0", Offset = "0x186F4D0", VA = "0x1818708D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0601ECCA RID: 126154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ECCB RID: 126155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047BC")]
		public Action<int, Act17sideData.EventData> onChoiceItemSelected
		{
			[Token(Token = "0x601ECCA")]
			[Address(RVA = "0x1870710", Offset = "0x186F310", VA = "0x181870710")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ECCB")]
			[Address(RVA = "0x1870850", Offset = "0x186F450", VA = "0x181870850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0601ECCC RID: 126156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ECCD RID: 126157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047BD")]
		public Action onBtnLeave
		{
			[Token(Token = "0x601ECCC")]
			[Address(RVA = "0x18706B0", Offset = "0x186F2B0", VA = "0x1818706B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ECCD")]
			[Address(RVA = "0x18707D0", Offset = "0x186F3D0", VA = "0x1818707D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ECCE RID: 126158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECCE")]
		[Address(RVA = "0x186DBD0", Offset = "0x186C7D0", VA = "0x18186DBD0")]
		public void HideAdditionViews()
		{
		}

		// Token: 0x0601ECCF RID: 126159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECCF")]
		[Address(RVA = "0x186DE70", Offset = "0x186CA70", VA = "0x18186DE70")]
		public void PlayEnterAnim(Action onComplete)
		{
		}

		// Token: 0x0601ECD0 RID: 126160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD0")]
		[Address(RVA = "0x186E720", Offset = "0x186D320", VA = "0x18186E720")]
		public void UpdateSpecialPic(string specialPicId)
		{
		}

		// Token: 0x0601ECD1 RID: 126161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD1")]
		[Address(RVA = "0x186E510", Offset = "0x186D110", VA = "0x18186E510")]
		public void UpdateNodePic(string nodePicId)
		{
		}

		// Token: 0x0601ECD2 RID: 126162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD2")]
		[Address(RVA = "0x186DC60", Offset = "0x186C860", VA = "0x18186DC60")]
		public void InitView()
		{
		}

		// Token: 0x0601ECD3 RID: 126163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD3")]
		[Address(RVA = "0x186ED70", Offset = "0x186D970", VA = "0x18186ED70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ECD4 RID: 126164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD4")]
		[Address(RVA = "0x186DFE0", Offset = "0x186CBE0", VA = "0x18186DFE0")]
		public void RenderStaticView(string actId, DeepSeaRPNodeModel nodeModel, Act17sideData.EventData lockedEventData)
		{
		}

		// Token: 0x0601ECD5 RID: 126165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD5")]
		[Address(RVA = "0x186DB50", Offset = "0x186C750", VA = "0x18186DB50")]
		public void ClearDesc()
		{
		}

		// Token: 0x0601ECD6 RID: 126166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECD6")]
		[Address(RVA = "0x186E490", Offset = "0x186D090", VA = "0x18186E490")]
		public void StopTyping()
		{
		}

		// Token: 0x0601ECD7 RID: 126167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECD7")]
		[Address(RVA = "0x186F0B0", Offset = "0x186DCB0", VA = "0x18186F0B0")]
		private Sprite _LoadSpecialPic(string picId)
		{
			return null;
		}

		// Token: 0x0601ECD8 RID: 126168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECD8")]
		[Address(RVA = "0x186EE00", Offset = "0x186DA00", VA = "0x18186EE00")]
		private Sprite _LoadNodePic(string picId)
		{
			return null;
		}

		// Token: 0x0601ECD9 RID: 126169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECD9")]
		[Address(RVA = "0x186EF30", Offset = "0x186DB30", VA = "0x18186EF30")]
		private Sprite _LoadPicFromAutoSpriteHub(AutoPackSpriteHub spriteHub, string picId)
		{
			return null;
		}

		// Token: 0x0601ECDA RID: 126170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECDA")]
		[Address(RVA = "0x186F1E0", Offset = "0x186DDE0", VA = "0x18186F1E0")]
		private void _PrepareFontSize(Text textComp, string desc)
		{
		}

		// Token: 0x0601ECDB RID: 126171 RVA: 0x000AFCF8 File Offset: 0x000ADEF8
		[Token(Token = "0x601ECDB")]
		[Address(RVA = "0x186E910", Offset = "0x186D510", VA = "0x18186E910")]
		private int _BinaryFind(Text textComp, string desc)
		{
			return 0;
		}

		// Token: 0x0601ECDC RID: 126172 RVA: 0x000AFD10 File Offset: 0x000ADF10
		[Token(Token = "0x601ECDC")]
		[Address(RVA = "0x186EA90", Offset = "0x186D690", VA = "0x18186EA90")]
		private bool _CheckSuitable(Text textComp, string desc, int fontSize, Vector2 extents)
		{
			return default(bool);
		}

		// Token: 0x0601ECDD RID: 126173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECDD")]
		[Address(RVA = "0x186DD60", Offset = "0x186C960", VA = "0x18186DD60")]
		public IEnumerator IntroCoroutine(DeepSeaRPNodeModel nodeModel, Act17sideData.EventData eventData, bool showAdditionView)
		{
			return null;
		}

		// Token: 0x0601ECDE RID: 126174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECDE")]
		[Address(RVA = "0x186F400", Offset = "0x186E000", VA = "0x18186F400")]
		private IEnumerator _ShowAdditionViewCoroutine(DeepSeaRPNodeModel nodeModel, string desc)
		{
			return null;
		}

		// Token: 0x0601ECDF RID: 126175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECDF")]
		[Address(RVA = "0x186F500", Offset = "0x186E100", VA = "0x18186F500")]
		private IEnumerator _ShowChoiceCoroutine(DeepSeaRPNodeModel nodeModel)
		{
			return null;
		}

		// Token: 0x0601ECE0 RID: 126176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECE0")]
		[Address(RVA = "0x186F8A0", Offset = "0x186E4A0", VA = "0x18186F8A0")]
		private void _UpdateChoiceView(DeepSeaRPChoiceModel choiceModel)
		{
		}

		// Token: 0x0601ECE1 RID: 126177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECE1")]
		[Address(RVA = "0x186F6A0", Offset = "0x186E2A0", VA = "0x18186F6A0")]
		private IEnumerator _ShowTechCoroutine(DeepSeaRPNodeModel nodeModel, string desc)
		{
			return null;
		}

		// Token: 0x0601ECE2 RID: 126178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECE2")]
		[Address(RVA = "0x186FC80", Offset = "0x186E880", VA = "0x18186FC80")]
		private void _UpdateTechView(DeepSeaRPTechNodeModel techModel)
		{
		}

		// Token: 0x0601ECE3 RID: 126179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECE3")]
		[Address(RVA = "0x186F7A0", Offset = "0x186E3A0", VA = "0x18186F7A0")]
		private IEnumerator _ShowTreasureCoroutine(DeepSeaRPNodeModel nodeModel, string desc)
		{
			return null;
		}

		// Token: 0x0601ECE4 RID: 126180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECE4")]
		[Address(RVA = "0x1870060", Offset = "0x186EC60", VA = "0x181870060")]
		private void _UpdateTresureView(DeepSeaRPTreasureNodeModel treasureModel)
		{
		}

		// Token: 0x0601ECE5 RID: 126181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECE5")]
		[Address(RVA = "0x186F5D0", Offset = "0x186E1D0", VA = "0x18186F5D0")]
		private IEnumerator _ShowStoryCoroutine(DeepSeaRPNodeModel nodeModel)
		{
			return null;
		}

		// Token: 0x0601ECE6 RID: 126182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECE6")]
		[Address(RVA = "0x186FBC0", Offset = "0x186E7C0", VA = "0x18186FBC0")]
		private void _UpdateStoryView(DeepSeaRPStoryNodeModel storyModel)
		{
		}

		// Token: 0x0601ECE7 RID: 126183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECE7")]
		[Address(RVA = "0x1870640", Offset = "0x186F240", VA = "0x181870640")]
		public DeepSeaRPNodeDetailView()
		{
		}

		// Token: 0x040294B9 RID: 169145
		[Token(Token = "0x40294B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040294BA RID: 169146
		[Token(Token = "0x40294BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _arrowGo;

		// Token: 0x040294BB RID: 169147
		[Token(Token = "0x40294BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnLeaveGo;

		// Token: 0x040294BC RID: 169148
		[Token(Token = "0x40294BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnActionGo;

		// Token: 0x040294BD RID: 169149
		[Token(Token = "0x40294BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _detailAtlas;

		// Token: 0x040294BE RID: 169150
		[Token(Token = "0x40294BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _commonIconGo;

		// Token: 0x040294BF RID: 169151
		[Token(Token = "0x40294BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgNodeIcon;

		// Token: 0x040294C0 RID: 169152
		[Token(Token = "0x40294C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgDeco;

		// Token: 0x040294C1 RID: 169153
		[Token(Token = "0x40294C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGTypeWriterText _typewriter;

		// Token: 0x040294C2 RID: 169154
		[Token(Token = "0x40294C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040294C3 RID: 169155
		[Token(Token = "0x40294C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _additionBlockGo;

		// Token: 0x040294C4 RID: 169156
		[Token(Token = "0x40294C4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgNodePic;

		// Token: 0x040294C5 RID: 169157
		[Token(Token = "0x40294C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgSpecialPic;

		// Token: 0x040294C6 RID: 169158
		[Token(Token = "0x40294C6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040294C7 RID: 169159
		[Token(Token = "0x40294C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Story")]
		private GameObject _storyViewGo;

		// Token: 0x040294C8 RID: 169160
		[Token(Token = "0x40294C8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Story")]
		private Text _textReadStory;

		// Token: 0x040294C9 RID: 169161
		[Token(Token = "0x40294C9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Story")]
		private UIAnimationLocation _storyEnterAnim;

		// Token: 0x040294CA RID: 169162
		[Token(Token = "0x40294CA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _chestViewGo;

		// Token: 0x040294CB RID: 169163
		[Token(Token = "0x40294CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Chest")]
		private UIAnimationLocation _chestEnterAnim;

		// Token: 0x040294CC RID: 169164
		[Token(Token = "0x40294CC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Chest")]
		private AVGTypeWriterText _chestTypewriter;

		// Token: 0x040294CD RID: 169165
		[Token(Token = "0x40294CD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Chest")]
		private Text _textChestDes;

		// Token: 0x040294CE RID: 169166
		[Token(Token = "0x40294CE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Chest")]
		private Text _textChestConfirm;

		// Token: 0x040294CF RID: 169167
		[Token(Token = "0x40294CF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _btnChestLeaveGo;

		// Token: 0x040294D0 RID: 169168
		[Token(Token = "0x40294D0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _btnChestConfirmGo;

		// Token: 0x040294D1 RID: 169169
		[Token(Token = "0x40294D1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _btnChestAlreadyGo;

		// Token: 0x040294D2 RID: 169170
		[Token(Token = "0x40294D2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Chest")]
		private Color _completeItemColor;

		// Token: 0x040294D3 RID: 169171
		[Token(Token = "0x40294D3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _completeMaskGo;

		// Token: 0x040294D4 RID: 169172
		[Token(Token = "0x40294D4")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Chest")]
		private Text _textMissionDesc;

		// Token: 0x040294D5 RID: 169173
		[Token(Token = "0x40294D5")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Chest")]
		private Color _colorMissionIncomplete;

		// Token: 0x040294D6 RID: 169174
		[Token(Token = "0x40294D6")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Chest")]
		private Color _colorMissionComplete;

		// Token: 0x040294D7 RID: 169175
		[Token(Token = "0x40294D7")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Chest")]
		private GameObject _rewardListGo;

		// Token: 0x040294D8 RID: 169176
		[Token(Token = "0x40294D8")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Chest")]
		private SimpleLayoutContent _chestRewardList;

		// Token: 0x040294D9 RID: 169177
		[Token(Token = "0x40294D9")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Chest")]
		private float _rewardItemScale;

		// Token: 0x040294DA RID: 169178
		[Token(Token = "0x40294DA")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Choice")]
		private GameObject _choiceViewGo;

		// Token: 0x040294DB RID: 169179
		[Token(Token = "0x40294DB")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Choice")]
		private UIAnimationLocation _choiceEnterAnim;

		// Token: 0x040294DC RID: 169180
		[Token(Token = "0x40294DC")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Choice")]
		private SimpleLayoutContent _choiceList;

		// Token: 0x040294DD RID: 169181
		[Token(Token = "0x40294DD")]
		[FieldOffset(Offset = "0x170")]
		private DeepSeaRPNodeDetailView.ChoiceListAdapter m_choiceListAdapter;

		// Token: 0x040294DE RID: 169182
		[Token(Token = "0x40294DE")]
		[FieldOffset(Offset = "0x178")]
		private DeepSeaRPNodeDetailView.MissionRewardListAdapter m_rewardListAdapter;

		// Token: 0x040294DF RID: 169183
		[Token(Token = "0x40294DF")]
		[FieldOffset(Offset = "0x180")]
		private bool m_hasInited;

		// Token: 0x040294E0 RID: 169184
		[Token(Token = "0x40294E0")]
		[FieldOffset(Offset = "0x184")]
		private int m_originFontSize;

		// Token: 0x040294E1 RID: 169185
		[Token(Token = "0x40294E1")]
		[FieldOffset(Offset = "0x188")]
		private AutoPackSpriteHub m_specialPicHub;

		// Token: 0x040294E2 RID: 169186
		[Token(Token = "0x40294E2")]
		[FieldOffset(Offset = "0x190")]
		private AutoPackSpriteHub m_nodePicHub;

		// Token: 0x040294E3 RID: 169187
		[Token(Token = "0x40294E3")]
		[FieldOffset(Offset = "0x198")]
		private string m_actId;

		// Token: 0x040294E7 RID: 169191
		[Token(Token = "0x40294E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x040294E8 RID: 169192
		[Token(Token = "0x40294E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x040294E9 RID: 169193
		[Token(Token = "0x40294E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onChoiceItemSelected;

		// Token: 0x040294EA RID: 169194
		[Token(Token = "0x40294EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onChoiceItemSelected;

		// Token: 0x040294EB RID: 169195
		[Token(Token = "0x40294EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onBtnLeave;

		// Token: 0x040294EC RID: 169196
		[Token(Token = "0x40294EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onBtnLeave;

		// Token: 0x040294ED RID: 169197
		[Token(Token = "0x40294ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideAdditionViews;

		// Token: 0x040294EE RID: 169198
		[Token(Token = "0x40294EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x040294EF RID: 169199
		[Token(Token = "0x40294EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateSpecialPic;

		// Token: 0x040294F0 RID: 169200
		[Token(Token = "0x40294F0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateNodePic;

		// Token: 0x040294F1 RID: 169201
		[Token(Token = "0x40294F1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x040294F2 RID: 169202
		[Token(Token = "0x40294F2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040294F3 RID: 169203
		[Token(Token = "0x40294F3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RenderStaticView;

		// Token: 0x040294F4 RID: 169204
		[Token(Token = "0x40294F4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClearDesc;

		// Token: 0x040294F5 RID: 169205
		[Token(Token = "0x40294F5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_StopTyping;

		// Token: 0x040294F6 RID: 169206
		[Token(Token = "0x40294F6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadSpecialPic;

		// Token: 0x040294F7 RID: 169207
		[Token(Token = "0x40294F7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadNodePic;

		// Token: 0x040294F8 RID: 169208
		[Token(Token = "0x40294F8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadPicFromAutoSpriteHub;

		// Token: 0x040294F9 RID: 169209
		[Token(Token = "0x40294F9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PrepareFontSize;

		// Token: 0x040294FA RID: 169210
		[Token(Token = "0x40294FA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__BinaryFind;

		// Token: 0x040294FB RID: 169211
		[Token(Token = "0x40294FB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckSuitable;

		// Token: 0x040294FC RID: 169212
		[Token(Token = "0x40294FC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IntroCoroutine;

		// Token: 0x040294FD RID: 169213
		[Token(Token = "0x40294FD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ShowAdditionViewCoroutine;

		// Token: 0x040294FE RID: 169214
		[Token(Token = "0x40294FE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ShowChoiceCoroutine;

		// Token: 0x040294FF RID: 169215
		[Token(Token = "0x40294FF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateChoiceView;

		// Token: 0x04029500 RID: 169216
		[Token(Token = "0x4029500")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ShowTechCoroutine;

		// Token: 0x04029501 RID: 169217
		[Token(Token = "0x4029501")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateTechView;

		// Token: 0x04029502 RID: 169218
		[Token(Token = "0x4029502")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ShowTreasureCoroutine;

		// Token: 0x04029503 RID: 169219
		[Token(Token = "0x4029503")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateTresureView;

		// Token: 0x04029504 RID: 169220
		[Token(Token = "0x4029504")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ShowStoryCoroutine;

		// Token: 0x04029505 RID: 169221
		[Token(Token = "0x4029505")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__UpdateStoryView;

		// Token: 0x04029506 RID: 169222
		[Token(Token = "0x4029506")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200516E RID: 20846
		[Token(Token = "0x200516E")]
		public enum IntroStep
		{
			// Token: 0x04029508 RID: 169224
			[Token(Token = "0x4029508")]
			IDLE,
			// Token: 0x04029509 RID: 169225
			[Token(Token = "0x4029509")]
			TYPING,
			// Token: 0x0402950A RID: 169226
			[Token(Token = "0x402950A")]
			WAIT_ACTION,
			// Token: 0x0402950B RID: 169227
			[Token(Token = "0x402950B")]
			UI_TWEEN
		}

		// Token: 0x0200516F RID: 20847
		[Token(Token = "0x200516F")]
		private class MissionRewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170047BE RID: 18366
			// (get) Token: 0x0601ECE8 RID: 126184 RVA: 0x000AFD28 File Offset: 0x000ADF28
			[Token(Token = "0x170047BE")]
			public override int count
			{
				[Token(Token = "0x601ECE8")]
				[Address(RVA = "0x1879610", Offset = "0x1878210", VA = "0x181879610", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ECE9 RID: 126185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ECE9")]
			[Address(RVA = "0x18792A0", Offset = "0x1877EA0", VA = "0x1818792A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601ECEA RID: 126186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ECEA")]
			[Address(RVA = "0x18794C0", Offset = "0x18780C0", VA = "0x1818794C0")]
			public void SetData(string actId, List<ItemBundle> rewards, float itemScale, bool isTreasureGot, Color _completeItemColor)
			{
			}

			// Token: 0x0601ECEB RID: 126187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ECEB")]
			[Address(RVA = "0x18795B0", Offset = "0x18781B0", VA = "0x1818795B0")]
			public MissionRewardListAdapter()
			{
			}

			// Token: 0x0402950C RID: 169228
			[Token(Token = "0x402950C")]
			[FieldOffset(Offset = "0x20")]
			private string m_actId;

			// Token: 0x0402950D RID: 169229
			[Token(Token = "0x402950D")]
			[FieldOffset(Offset = "0x28")]
			private List<ItemBundle> m_rewards;

			// Token: 0x0402950E RID: 169230
			[Token(Token = "0x402950E")]
			[FieldOffset(Offset = "0x30")]
			private float m_itemScale;

			// Token: 0x0402950F RID: 169231
			[Token(Token = "0x402950F")]
			[FieldOffset(Offset = "0x34")]
			private bool m_isGot;

			// Token: 0x04029510 RID: 169232
			[Token(Token = "0x4029510")]
			[FieldOffset(Offset = "0x38")]
			private Color m_color;

			// Token: 0x04029511 RID: 169233
			[Token(Token = "0x4029511")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029512 RID: 169234
			[Token(Token = "0x4029512")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04029513 RID: 169235
			[Token(Token = "0x4029513")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04029514 RID: 169236
			[Token(Token = "0x4029514")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005170 RID: 20848
		[Token(Token = "0x2005170")]
		private class ChoiceListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601ECEC RID: 126188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ECEC")]
			[Address(RVA = "0x1866120", Offset = "0x1864D20", VA = "0x181866120")]
			public void SetData(DeepSeaRPChoiceModel choiceModel)
			{
			}

			// Token: 0x170047BF RID: 18367
			// (get) Token: 0x0601ECED RID: 126189 RVA: 0x000AFD40 File Offset: 0x000ADF40
			[Token(Token = "0x170047BF")]
			public override int count
			{
				[Token(Token = "0x601ECED")]
				[Address(RVA = "0x1866200", Offset = "0x1864E00", VA = "0x181866200", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170047C0 RID: 18368
			// (get) Token: 0x0601ECEE RID: 126190 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601ECEF RID: 126191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170047C0")]
			public Action<int, Act17sideData.EventData> onItemSelect
			{
				[Token(Token = "0x601ECEE")]
				[Address(RVA = "0x1866300", Offset = "0x1864F00", VA = "0x181866300")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601ECEF")]
				[Address(RVA = "0x18663E0", Offset = "0x1864FE0", VA = "0x1818663E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170047C1 RID: 18369
			// (get) Token: 0x0601ECF0 RID: 126192 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601ECF1 RID: 126193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170047C1")]
			public Action onBtnLeave
			{
				[Token(Token = "0x601ECF0")]
				[Address(RVA = "0x18662A0", Offset = "0x1864EA0", VA = "0x1818662A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601ECF1")]
				[Address(RVA = "0x1866360", Offset = "0x1864F60", VA = "0x181866360")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601ECF2 RID: 126194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ECF2")]
			[Address(RVA = "0x1865E60", Offset = "0x1864A60", VA = "0x181865E60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601ECF3 RID: 126195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ECF3")]
			[Address(RVA = "0x18661A0", Offset = "0x1864DA0", VA = "0x1818661A0")]
			public ChoiceListAdapter()
			{
			}

			// Token: 0x04029515 RID: 169237
			[Token(Token = "0x4029515")]
			[FieldOffset(Offset = "0x20")]
			private DeepSeaRPChoiceModel m_choiceModel;

			// Token: 0x04029518 RID: 169240
			[Token(Token = "0x4029518")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04029519 RID: 169241
			[Token(Token = "0x4029519")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402951A RID: 169242
			[Token(Token = "0x402951A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onItemSelect;

			// Token: 0x0402951B RID: 169243
			[Token(Token = "0x402951B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onItemSelect;

			// Token: 0x0402951C RID: 169244
			[Token(Token = "0x402951C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_onBtnLeave;

			// Token: 0x0402951D RID: 169245
			[Token(Token = "0x402951D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_onBtnLeave;

			// Token: 0x0402951E RID: 169246
			[Token(Token = "0x402951E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402951F RID: 169247
			[Token(Token = "0x402951F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
