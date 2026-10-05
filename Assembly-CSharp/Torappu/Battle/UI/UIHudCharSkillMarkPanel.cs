using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335E RID: 13150
	[Token(Token = "0x200335E")]
	public class UIHudCharSkillMarkPanel : MonoBehaviour, HudPlugin, IHotfixable
	{
		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x06014FC3 RID: 85955 RVA: 0x00089EF8 File Offset: 0x000880F8
		[Token(Token = "0x170031D2")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FC3")]
			[Address(RVA = "0xD5EED0", Offset = "0xD5DAD0", VA = "0x180D5EED0", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x06014FC4 RID: 85956 RVA: 0x00089F10 File Offset: 0x00088110
		[Token(Token = "0x170031D3")]
		public bool needToShow
		{
			[Token(Token = "0x6014FC4")]
			[Address(RVA = "0xD5EF30", Offset = "0xD5DB30", VA = "0x180D5EF30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FC5 RID: 85957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC5")]
		[Address(RVA = "0xD5DAE0", Offset = "0xD5C6E0", VA = "0x180D5DAE0", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FC6 RID: 85958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC6")]
		[Address(RVA = "0xD5DE60", Offset = "0xD5CA60", VA = "0x180D5DE60", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FC7 RID: 85959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC7")]
		[Address(RVA = "0xD5E070", Offset = "0xD5CC70", VA = "0x180D5E070", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FC8 RID: 85960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC8")]
		[Address(RVA = "0xD5EBB0", Offset = "0xD5D7B0", VA = "0x180D5EBB0")]
		private void _UpdateManualSkillSuspendable(Character character)
		{
		}

		// Token: 0x06014FC9 RID: 85961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC9")]
		[Address(RVA = "0xD5ED00", Offset = "0xD5D900", VA = "0x180D5ED00")]
		protected void _UpdateSkillCntLabelIfChanged(Character character)
		{
		}

		// Token: 0x06014FCA RID: 85962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FCA")]
		[Address(RVA = "0xD5E830", Offset = "0xD5D430", VA = "0x180D5E830")]
		protected void _UpdateManualSkillMark(Character character)
		{
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FCB")]
		[Address(RVA = "0xD5E4F0", Offset = "0xD5D0F0", VA = "0x180D5E4F0")]
		private void _FollowPosition(Transform headTransform)
		{
		}

		// Token: 0x06014FCC RID: 85964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FCC")]
		[Address(RVA = "0xD5EE50", Offset = "0xD5DA50", VA = "0x180D5EE50")]
		public UIHudCharSkillMarkPanel()
		{
		}

		// Token: 0x04018F5F RID: 102239
		[Token(Token = "0x4018F5F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _manualSkillMark;

		// Token: 0x04018F60 RID: 102240
		[Token(Token = "0x4018F60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _manualSkillMarkEnhance;

		// Token: 0x04018F61 RID: 102241
		[Token(Token = "0x4018F61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _manualSkillSuspendable;

		// Token: 0x04018F62 RID: 102242
		[Token(Token = "0x4018F62")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _autoSkillMark;

		// Token: 0x04018F63 RID: 102243
		[Token(Token = "0x4018F63")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _skillCntLabel;

		// Token: 0x04018F64 RID: 102244
		[Token(Token = "0x4018F64")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _manualSkillRetriggerMark;

		// Token: 0x04018F65 RID: 102245
		[Token(Token = "0x4018F65")]
		[FieldOffset(Offset = "0x48")]
		private int m_lastFrameAvailableCnt;

		// Token: 0x04018F66 RID: 102246
		[Token(Token = "0x4018F66")]
		[FieldOffset(Offset = "0x50")]
		private Character m_char;

		// Token: 0x04018F67 RID: 102247
		[Token(Token = "0x4018F67")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isTrap;

		// Token: 0x04018F68 RID: 102248
		[Token(Token = "0x4018F68")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 m_originalSkillLocalPosition;

		// Token: 0x04018F69 RID: 102249
		[Token(Token = "0x4018F69")]
		[FieldOffset(Offset = "0x68")]
		private readonly Vector3 m_defaultSkillMarkLocalPositionOffset;

		// Token: 0x04018F6A RID: 102250
		[Token(Token = "0x4018F6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F6B RID: 102251
		[Token(Token = "0x4018F6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F6C RID: 102252
		[Token(Token = "0x4018F6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F6D RID: 102253
		[Token(Token = "0x4018F6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F6E RID: 102254
		[Token(Token = "0x4018F6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F6F RID: 102255
		[Token(Token = "0x4018F6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateManualSkillSuspendable;

		// Token: 0x04018F70 RID: 102256
		[Token(Token = "0x4018F70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSkillCntLabelIfChanged;

		// Token: 0x04018F71 RID: 102257
		[Token(Token = "0x4018F71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateManualSkillMark;

		// Token: 0x04018F72 RID: 102258
		[Token(Token = "0x4018F72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FollowPosition;

		// Token: 0x04018F73 RID: 102259
		[Token(Token = "0x4018F73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
