using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C8C RID: 19596
	[Token(Token = "0x2004C8C")]
	public class OpenServerV2MissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D5FF RID: 120319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5FF")]
		[Address(RVA = "0x16F0910", Offset = "0x16EF510", VA = "0x1816F0910")]
		public void Render(int index, OpenServerV2MissionItemData missionItemData)
		{
		}

		// Token: 0x0601D600 RID: 120320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D600")]
		[Address(RVA = "0x16F0780", Offset = "0x16EF380", VA = "0x1816F0780")]
		public void OnClick()
		{
		}

		// Token: 0x0601D601 RID: 120321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D601")]
		[Address(RVA = "0x16F0C70", Offset = "0x16EF870", VA = "0x1816F0C70")]
		private void _OnMissionItemClick()
		{
		}

		// Token: 0x0601D602 RID: 120322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D602")]
		[Address(RVA = "0x16F0D60", Offset = "0x16EF960", VA = "0x1816F0D60")]
		private void _RenderMissionState(MissionPlayerState missionPlayerState)
		{
		}

		// Token: 0x0601D603 RID: 120323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D603")]
		[Address(RVA = "0x16F0FF0", Offset = "0x16EFBF0", VA = "0x1816F0FF0")]
		public OpenServerV2MissionItem()
		{
		}

		// Token: 0x04026AA9 RID: 158377
		[Token(Token = "0x4026AA9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtContent;

		// Token: 0x04026AAA RID: 158378
		[Token(Token = "0x4026AAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtItem;

		// Token: 0x04026AAB RID: 158379
		[Token(Token = "0x4026AAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04026AAC RID: 158380
		[Token(Token = "0x4026AAC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtItemCount;

		// Token: 0x04026AAD RID: 158381
		[Token(Token = "0x4026AAD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtMissionProcess;

		// Token: 0x04026AAE RID: 158382
		[Token(Token = "0x4026AAE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _fullProcessBar;

		// Token: 0x04026AAF RID: 158383
		[Token(Token = "0x4026AAF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _processBar;

		// Token: 0x04026AB0 RID: 158384
		[Token(Token = "0x4026AB0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNotComplete;

		// Token: 0x04026AB1 RID: 158385
		[Token(Token = "0x4026AB1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelAvailable;

		// Token: 0x04026AB2 RID: 158386
		[Token(Token = "0x4026AB2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelAlreadyGot;

		// Token: 0x04026AB3 RID: 158387
		[Token(Token = "0x4026AB3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroupRight;

		// Token: 0x04026AB4 RID: 158388
		[Token(Token = "0x4026AB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04026AB5 RID: 158389
		[Token(Token = "0x4026AB5")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026AB6 RID: 158390
		[Token(Token = "0x4026AB6")]
		[FieldOffset(Offset = "0x90")]
		private string m_missionId;

		// Token: 0x04026AB7 RID: 158391
		[Token(Token = "0x4026AB7")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_tween;

		// Token: 0x04026AB8 RID: 158392
		[Token(Token = "0x4026AB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026AB9 RID: 158393
		[Token(Token = "0x4026AB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026ABA RID: 158394
		[Token(Token = "0x4026ABA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnMissionItemClick;

		// Token: 0x04026ABB RID: 158395
		[Token(Token = "0x4026ABB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMissionState;

		// Token: 0x04026ABC RID: 158396
		[Token(Token = "0x4026ABC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
