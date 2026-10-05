using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.Scripts.Building.DIY;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A72 RID: 6770
	[Token(Token = "0x2001A72")]
	public class VFurnitureEntity : VRoom.Object, IHotfixable, VRoom.IVCharInteractable
	{
		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600AA87 RID: 43655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001412")]
		public Transform focusCenter
		{
			[Token(Token = "0x600AA87")]
			[Address(RVA = "0x32619D0", Offset = "0x32605D0", VA = "0x1832619D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA88")]
		[Address(RVA = "0x32610F0", Offset = "0x325FCF0", VA = "0x1832610F0")]
		private void _OnAnimatorStateChange(string stateName, AnimatorStateEvent stateEvent)
		{
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001413")]
		protected virtual string interactAnimation
		{
			[Token(Token = "0x600AA89")]
			[Address(RVA = "0x3261A90", Offset = "0x3260690", VA = "0x183261A90", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001414")]
		public string id
		{
			[Token(Token = "0x600AA8A")]
			[Address(RVA = "0x3261A30", Offset = "0x3260630", VA = "0x183261A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001415")]
		public string musicId
		{
			[Token(Token = "0x600AA8B")]
			[Address(RVA = "0x3261C90", Offset = "0x3260890", VA = "0x183261C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600AA8C RID: 43660 RVA: 0x00042048 File Offset: 0x00040248
		[Token(Token = "0x17001416")]
		public override Vector3 worldCenter
		{
			[Token(Token = "0x600AA8C")]
			[Address(RVA = "0x3261E80", Offset = "0x3260A80", VA = "0x183261E80", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600AA8D RID: 43661 RVA: 0x00042060 File Offset: 0x00040260
		[Token(Token = "0x17001417")]
		public bool isMusicFurniture
		{
			[Token(Token = "0x600AA8D")]
			[Address(RVA = "0x3261B60", Offset = "0x3260760", VA = "0x183261B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x00042078 File Offset: 0x00040278
		[Token(Token = "0x17001418")]
		public bool isPlaying
		{
			[Token(Token = "0x600AA8E")]
			[Address(RVA = "0x3261C30", Offset = "0x3260830", VA = "0x183261C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x00042090 File Offset: 0x00040290
		[Token(Token = "0x17001419")]
		public bool isFunctional
		{
			[Token(Token = "0x600AA8F")]
			[Address(RVA = "0x3261B00", Offset = "0x3260700", VA = "0x183261B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x000420A8 File Offset: 0x000402A8
		[Token(Token = "0x1700141A")]
		public bool isOutlineOn
		{
			[Token(Token = "0x600AA90")]
			[Address(RVA = "0x3261BC0", Offset = "0x32607C0", VA = "0x183261BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x000420C0 File Offset: 0x000402C0
		[Token(Token = "0x1700141B")]
		public BuildingData.FurnitureSubType subType
		{
			[Token(Token = "0x600AA91")]
			[Address(RVA = "0x3261CF0", Offset = "0x32608F0", VA = "0x183261CF0")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600AA92 RID: 43666 RVA: 0x000420D8 File Offset: 0x000402D8
		[Token(Token = "0x1700141C")]
		public Bounds bounds
		{
			[Token(Token = "0x600AA92")]
			[Address(RVA = "0x3261870", Offset = "0x3260470", VA = "0x183261870")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700141D")]
		public VFurnitureOutline vFurnitureOutline
		{
			[Token(Token = "0x600AA93")]
			[Address(RVA = "0x3261DB0", Offset = "0x32609B0", VA = "0x183261DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA94")]
		[Address(RVA = "0x325F3F0", Offset = "0x325DFF0", VA = "0x18325F3F0", Slot = "12")]
		public override void Init(VRoom room, VGridPlane plane)
		{
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA95")]
		[Address(RVA = "0x325FE40", Offset = "0x325EA40", VA = "0x18325FE40", Slot = "13")]
		public override void OnInit()
		{
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA96")]
		[Address(RVA = "0x32607D0", Offset = "0x325F3D0", VA = "0x1832607D0")]
		public void SetData(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA97")]
		[Address(RVA = "0x325F930", Offset = "0x325E530", VA = "0x18325F930", Slot = "14")]
		public override void OnEnter()
		{
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA98")]
		[Address(RVA = "0x325FBA0", Offset = "0x325E7A0", VA = "0x18325FBA0", Slot = "15")]
		public override void OnExit()
		{
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x000420F0 File Offset: 0x000402F0
		[Token(Token = "0x600AA99")]
		[Address(RVA = "0x32603F0", Offset = "0x325EFF0", VA = "0x1832603F0", Slot = "16")]
		public override bool OnInteract()
		{
			return default(bool);
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9A")]
		[Address(RVA = "0x3260B40", Offset = "0x325F740", VA = "0x183260B40")]
		private void _DoInteract()
		{
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9B")]
		[Address(RVA = "0x3260A00", Offset = "0x325F600", VA = "0x183260A00")]
		public void StoppedByOthers()
		{
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9C")]
		[Address(RVA = "0x325F290", Offset = "0x325DE90", VA = "0x18325F290")]
		public void EnableOutline(bool value)
		{
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9D")]
		[Address(RVA = "0x3260750", Offset = "0x325F350", VA = "0x183260750")]
		public void ResetOutline()
		{
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA9E")]
		[Address(RVA = "0x325F320", Offset = "0x325DF20", VA = "0x18325F320")]
		public Transform GetFuncFurnitureBtnPos()
		{
			return null;
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9F")]
		[Address(RVA = "0x3260690", Offset = "0x325F290", VA = "0x183260690")]
		public void OpenFunctionPage()
		{
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA0")]
		[Address(RVA = "0x3260E80", Offset = "0x325FA80", VA = "0x183260E80")]
		protected void _InteractAnimation(string triggerName)
		{
		}

		// Token: 0x0600AAA1 RID: 43681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA1")]
		[Address(RVA = "0x3261000", Offset = "0x325FC00", VA = "0x183261000")]
		private void _InteractAnimation(string triggerName, bool value)
		{
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAA2")]
		[Address(RVA = "0x3261680", Offset = "0x3260280", VA = "0x183261680")]
		protected IEnumerator _WaitInteractCooldown()
		{
			return null;
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA3")]
		[Address(RVA = "0x32614F0", Offset = "0x32600F0", VA = "0x1832614F0")]
		private void _PlayMusic()
		{
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA4")]
		[Address(RVA = "0x32615E0", Offset = "0x32601E0", VA = "0x1832615E0")]
		private void _StopMusic()
		{
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x00042108 File Offset: 0x00040308
		[Token(Token = "0x600AAA5")]
		[Address(RVA = "0x325F4A0", Offset = "0x325E0A0", VA = "0x18325F4A0", Slot = "19")]
		public bool IsVCharInteractable(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600AAA6 RID: 43686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA6")]
		[Address(RVA = "0x3260610", Offset = "0x325F210", VA = "0x183260610", Slot = "20")]
		public void OnVCharInteract(VCharacter character)
		{
		}

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA7")]
		[Address(RVA = "0x3260590", Offset = "0x325F190", VA = "0x183260590", Slot = "21")]
		public void OnInteractableChanged(bool interactable)
		{
		}

		// Token: 0x0600AAA8 RID: 43688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA8")]
		[Address(RVA = "0x325F820", Offset = "0x325E420", VA = "0x18325F820")]
		private void OnDisable()
		{
		}

		// Token: 0x0600AAA9 RID: 43689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA9")]
		[Address(RVA = "0x325F8A0", Offset = "0x325E4A0", VA = "0x18325F8A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAAA")]
		[Address(RVA = "0x325F560", Offset = "0x325E160", VA = "0x18325F560")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAAB")]
		[Address(RVA = "0x3261730", Offset = "0x3260330", VA = "0x183261730")]
		public VFurnitureEntity()
		{
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAAC")]
		[Address(RVA = "0x3260B30", Offset = "0x325F730", VA = "0x183260B30")]
		private void <>xLuaBaseProxy_Init(VRoom P0, VGridPlane P1)
		{
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x00042120 File Offset: 0x00040320
		[Token(Token = "0x600AAAD")]
		[Address(RVA = "0x322C010", Offset = "0x322AC10", VA = "0x18322C010")]
		private bool <>xLuaBaseProxy_OnInteract()
		{
			return default(bool);
		}

		// Token: 0x0400A2D7 RID: 41687
		[Token(Token = "0x400A2D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _focusCenter;

		// Token: 0x0400A2D8 RID: 41688
		[Token(Token = "0x400A2D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Animator _animPlayer;

		// Token: 0x0400A2D9 RID: 41689
		[Token(Token = "0x400A2D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FurnitureEntity _furnitureEntity;

		// Token: 0x0400A2DA RID: 41690
		[Token(Token = "0x400A2DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VFurnitureEntity.AnimatorEventController> _animatorEventControllers;

		// Token: 0x0400A2DB RID: 41691
		[Token(Token = "0x400A2DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("RandomAnim")]
		private bool _isRandomAnim;

		// Token: 0x0400A2DC RID: 41692
		[Token(Token = "0x400A2DC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("RandomAnim")]
		private List<string> _randomTriggerName;

		// Token: 0x0400A2DD RID: 41693
		[Token(Token = "0x400A2DD")]
		[FieldOffset(Offset = "0x60")]
		private string m_musicId;

		// Token: 0x0400A2DE RID: 41694
		[Token(Token = "0x400A2DE")]
		[FieldOffset(Offset = "0x68")]
		private string m_id;

		// Token: 0x0400A2DF RID: 41695
		[Token(Token = "0x400A2DF")]
		[FieldOffset(Offset = "0x70")]
		protected bool m_isInteractable;

		// Token: 0x0400A2E0 RID: 41696
		[Token(Token = "0x400A2E0")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_worldCenter;

		// Token: 0x0400A2E1 RID: 41697
		[Token(Token = "0x400A2E1")]
		[FieldOffset(Offset = "0x80")]
		protected Coroutine m_coroutine;

		// Token: 0x0400A2E2 RID: 41698
		[Token(Token = "0x400A2E2")]
		[FieldOffset(Offset = "0x88")]
		private VFurnitureOutline m_vFurnitureOutline;

		// Token: 0x0400A2E3 RID: 41699
		[Token(Token = "0x400A2E3")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0400A2E4 RID: 41700
		[Token(Token = "0x400A2E4")]
		[FieldOffset(Offset = "0x98")]
		private FurnitureAnimatorBehaviour[] m_behaviours;

		// Token: 0x0400A2E5 RID: 41701
		[Token(Token = "0x400A2E5")]
		[FieldOffset(Offset = "0xA0")]
		private List<VFurnitureEntity.AnimatorEventController> m_animatorEventControllers;

		// Token: 0x0400A2E6 RID: 41702
		[Token(Token = "0x400A2E6")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isPlaying;

		// Token: 0x0400A2E7 RID: 41703
		[Token(Token = "0x400A2E7")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_isMusicPlaying;

		// Token: 0x0400A2E8 RID: 41704
		[Token(Token = "0x400A2E8")]
		[FieldOffset(Offset = "0xAC")]
		private FurnitureInteractType m_furnitureInteractType;

		// Token: 0x0400A2E9 RID: 41705
		[Token(Token = "0x400A2E9")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isRandomAnim;

		// Token: 0x0400A2EA RID: 41706
		[Token(Token = "0x400A2EA")]
		[FieldOffset(Offset = "0xB8")]
		private List<string> m_randomTriggerName;

		// Token: 0x0400A2EB RID: 41707
		[Token(Token = "0x400A2EB")]
		[FieldOffset(Offset = "0xC0")]
		private string m_curTriggerName;

		// Token: 0x0400A2EC RID: 41708
		[Token(Token = "0x400A2EC")]
		[FieldOffset(Offset = "0xC8")]
		private System.Random m_random;

		// Token: 0x0400A2ED RID: 41709
		[Token(Token = "0x400A2ED")]
		[FieldOffset(Offset = "0xD0")]
		private BuildingData.FurnitureType m_furniType;

		// Token: 0x0400A2EE RID: 41710
		[Token(Token = "0x400A2EE")]
		[FieldOffset(Offset = "0xD8")]
		private VFuncFurniture m_funcFurniture;

		// Token: 0x0400A2EF RID: 41711
		[Token(Token = "0x400A2EF")]
		[FieldOffset(Offset = "0xE0")]
		private DIYRoom.IFurnitureController m_controller;

		// Token: 0x0400A2F0 RID: 41712
		[Token(Token = "0x400A2F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusCenter;

		// Token: 0x0400A2F1 RID: 41713
		[Token(Token = "0x400A2F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnAnimatorStateChange;

		// Token: 0x0400A2F2 RID: 41714
		[Token(Token = "0x400A2F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_interactAnimation;

		// Token: 0x0400A2F3 RID: 41715
		[Token(Token = "0x400A2F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0400A2F4 RID: 41716
		[Token(Token = "0x400A2F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_musicId;

		// Token: 0x0400A2F5 RID: 41717
		[Token(Token = "0x400A2F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_worldCenter;

		// Token: 0x0400A2F6 RID: 41718
		[Token(Token = "0x400A2F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isMusicFurniture;

		// Token: 0x0400A2F7 RID: 41719
		[Token(Token = "0x400A2F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x0400A2F8 RID: 41720
		[Token(Token = "0x400A2F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isFunctional;

		// Token: 0x0400A2F9 RID: 41721
		[Token(Token = "0x400A2F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isOutlineOn;

		// Token: 0x0400A2FA RID: 41722
		[Token(Token = "0x400A2FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_subType;

		// Token: 0x0400A2FB RID: 41723
		[Token(Token = "0x400A2FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_bounds;

		// Token: 0x0400A2FC RID: 41724
		[Token(Token = "0x400A2FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_vFurnitureOutline;

		// Token: 0x0400A2FD RID: 41725
		[Token(Token = "0x400A2FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A2FE RID: 41726
		[Token(Token = "0x400A2FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A2FF RID: 41727
		[Token(Token = "0x400A2FF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400A300 RID: 41728
		[Token(Token = "0x400A300")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A301 RID: 41729
		[Token(Token = "0x400A301")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A302 RID: 41730
		[Token(Token = "0x400A302")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnInteract;

		// Token: 0x0400A303 RID: 41731
		[Token(Token = "0x400A303")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoInteract;

		// Token: 0x0400A304 RID: 41732
		[Token(Token = "0x400A304")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_StoppedByOthers;

		// Token: 0x0400A305 RID: 41733
		[Token(Token = "0x400A305")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EnableOutline;

		// Token: 0x0400A306 RID: 41734
		[Token(Token = "0x400A306")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ResetOutline;

		// Token: 0x0400A307 RID: 41735
		[Token(Token = "0x400A307")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetFuncFurnitureBtnPos;

		// Token: 0x0400A308 RID: 41736
		[Token(Token = "0x400A308")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OpenFunctionPage;

		// Token: 0x0400A309 RID: 41737
		[Token(Token = "0x400A309")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InteractAnimation;

		// Token: 0x0400A30A RID: 41738
		[Token(Token = "0x400A30A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1__InteractAnimation;

		// Token: 0x0400A30B RID: 41739
		[Token(Token = "0x400A30B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__WaitInteractCooldown;

		// Token: 0x0400A30C RID: 41740
		[Token(Token = "0x400A30C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__PlayMusic;

		// Token: 0x0400A30D RID: 41741
		[Token(Token = "0x400A30D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__StopMusic;

		// Token: 0x0400A30E RID: 41742
		[Token(Token = "0x400A30E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_IsVCharInteractable;

		// Token: 0x0400A30F RID: 41743
		[Token(Token = "0x400A30F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnVCharInteract;

		// Token: 0x0400A310 RID: 41744
		[Token(Token = "0x400A310")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnInteractableChanged;

		// Token: 0x0400A311 RID: 41745
		[Token(Token = "0x400A311")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400A312 RID: 41746
		[Token(Token = "0x400A312")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400A313 RID: 41747
		[Token(Token = "0x400A313")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A314 RID: 41748
		[Token(Token = "0x400A314")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A73 RID: 6771
		[Token(Token = "0x2001A73")]
		[Serializable]
		private class AnimatorEventInfo
		{
			// Token: 0x1700141E RID: 5150
			// (get) Token: 0x0600AAAE RID: 43694 RVA: 0x00042138 File Offset: 0x00040338
			[Token(Token = "0x1700141E")]
			public AnimatorStateEvent stateEvent
			{
				[Token(Token = "0x600AAAE")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return AnimatorStateEvent.OnEnter;
				}
			}

			// Token: 0x1700141F RID: 5151
			// (get) Token: 0x0600AAAF RID: 43695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700141F")]
			public string stateName
			{
				[Token(Token = "0x600AAAF")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001420 RID: 5152
			// (get) Token: 0x0600AAB0 RID: 43696 RVA: 0x00042150 File Offset: 0x00040350
			[Token(Token = "0x17001420")]
			public bool emitSignal
			{
				[Token(Token = "0x600AAB0")]
				[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600AAB1 RID: 43697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimatorEventInfo()
			{
			}

			// Token: 0x0400A315 RID: 41749
			[Token(Token = "0x400A315")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _stateName;

			// Token: 0x0400A316 RID: 41750
			[Token(Token = "0x400A316")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private AnimatorStateEvent _stateEvent;

			// Token: 0x0400A317 RID: 41751
			[Token(Token = "0x400A317")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private bool _emitSignal;
		}

		// Token: 0x02001A74 RID: 6772
		[Token(Token = "0x2001A74")]
		[Serializable]
		private class AnimatorEventController
		{
			// Token: 0x0600AAB2 RID: 43698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB2")]
			[Address(RVA = "0x3250AF0", Offset = "0x324F6F0", VA = "0x183250AF0")]
			public void Init(VFurnitureEntity vFurniture)
			{
			}

			// Token: 0x17001421 RID: 5153
			// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001421")]
			public VFurnitureEntity.AnimatorEventInfo playInfo
			{
				[Token(Token = "0x600AAB3")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001422 RID: 5154
			// (get) Token: 0x0600AAB4 RID: 43700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001422")]
			public VFurnitureEntity.AnimatorEventInfo stopInfo
			{
				[Token(Token = "0x600AAB4")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001423 RID: 5155
			// (get) Token: 0x0600AAB5 RID: 43701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001423")]
			public VFurnitureEntity.AnimatorEventInfo triggerInfo
			{
				[Token(Token = "0x600AAB5")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600AAB6 RID: 43702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB6")]
			[Address(RVA = "0x3250D20", Offset = "0x324F920", VA = "0x183250D20")]
			public void Play()
			{
			}

			// Token: 0x0600AAB7 RID: 43703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB7")]
			[Address(RVA = "0x3250F90", Offset = "0x324FB90", VA = "0x183250F90")]
			public void Stop()
			{
			}

			// Token: 0x0600AAB8 RID: 43704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB8")]
			[Address(RVA = "0x3250E50", Offset = "0x324FA50", VA = "0x183250E50")]
			public void SetTrigger(string triggerKey = "onInteract")
			{
			}

			// Token: 0x0600AAB9 RID: 43705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB9")]
			[Address(RVA = "0x3250C20", Offset = "0x324F820", VA = "0x183250C20")]
			public void OnExit()
			{
			}

			// Token: 0x0600AABA RID: 43706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABA")]
			[Address(RVA = "0x32510C0", Offset = "0x324FCC0", VA = "0x1832510C0")]
			private void _EmitSignal(VFurnitureEntity.AnimatorEventInfo animEventInfo)
			{
			}

			// Token: 0x0600AABB RID: 43707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABB")]
			[Address(RVA = "0x3251430", Offset = "0x3250030", VA = "0x183251430")]
			public AnimatorEventController()
			{
			}

			// Token: 0x0400A318 RID: 41752
			[Token(Token = "0x400A318")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private VFurnitureEntity.AnimatorEventInfo _playInfo;

			// Token: 0x0400A319 RID: 41753
			[Token(Token = "0x400A319")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private VFurnitureEntity.AnimatorEventInfo _stopInfo;

			// Token: 0x0400A31A RID: 41754
			[Token(Token = "0x400A31A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private VFurnitureEntity.AnimatorEventInfo _triggerInfo;

			// Token: 0x0400A31B RID: 41755
			[Token(Token = "0x400A31B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<BuildingEffect> _effects;

			// Token: 0x0400A31C RID: 41756
			[Token(Token = "0x400A31C")]
			[FieldOffset(Offset = "0x30")]
			private VFurnitureEntity m_vFurniture;
		}
	}
}
