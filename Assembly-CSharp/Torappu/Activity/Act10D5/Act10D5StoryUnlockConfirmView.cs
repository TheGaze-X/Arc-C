using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B35 RID: 31541
	[Token(Token = "0x2007B35")]
	public class Act10D5StoryUnlockConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C278 RID: 180856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C278")]
		[Address(RVA = "0x280C870", Offset = "0x280B470", VA = "0x18280C870")]
		public void Initialize()
		{
		}

		// Token: 0x0602C279 RID: 180857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C279")]
		[Address(RVA = "0x280CCD0", Offset = "0x280B8D0", VA = "0x18280CCD0")]
		private void _Init()
		{
		}

		// Token: 0x0602C27A RID: 180858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27A")]
		[Address(RVA = "0x280CB60", Offset = "0x280B760", VA = "0x18280CB60")]
		public void RenderLockedPart(int count, string itemId, ItemType itemType, string iconId, Action onClick)
		{
		}

		// Token: 0x0602C27B RID: 180859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27B")]
		[Address(RVA = "0x280C990", Offset = "0x280B590", VA = "0x18280C990")]
		public void OnClick()
		{
		}

		// Token: 0x0602C27C RID: 180860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27C")]
		[Address(RVA = "0x280C6C0", Offset = "0x280B2C0", VA = "0x18280C6C0")]
		public void ClosePage()
		{
		}

		// Token: 0x0602C27D RID: 180861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27D")]
		[Address(RVA = "0x280CAE0", Offset = "0x280B6E0", VA = "0x18280CAE0")]
		private void OnDisable()
		{
		}

		// Token: 0x0602C27E RID: 180862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27E")]
		[Address(RVA = "0x280CFF0", Offset = "0x280BBF0", VA = "0x18280CFF0")]
		private void _RenderBackImage()
		{
		}

		// Token: 0x0602C27F RID: 180863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C27F")]
		[Address(RVA = "0x280D1B0", Offset = "0x280BDB0", VA = "0x18280D1B0")]
		private void _RenderLockedPart(int count, string itemId, ItemType itemType, string iconId, Action onClick)
		{
		}

		// Token: 0x0602C280 RID: 180864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C280")]
		[Address(RVA = "0x280CC20", Offset = "0x280B820", VA = "0x18280CC20")]
		private IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602C281 RID: 180865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C281")]
		[Address(RVA = "0x280C7C0", Offset = "0x280B3C0", VA = "0x18280C7C0")]
		private IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0602C282 RID: 180866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C282")]
		[Address(RVA = "0x280D4B0", Offset = "0x280C0B0", VA = "0x18280D4B0")]
		public Act10D5StoryUnlockConfirmView()
		{
		}

		// Token: 0x04040024 RID: 262180
		[Token(Token = "0x4040024")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x04040025 RID: 262181
		[Token(Token = "0x4040025")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unlockPart;

		// Token: 0x04040026 RID: 262182
		[Token(Token = "0x4040026")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _container;

		// Token: 0x04040027 RID: 262183
		[Token(Token = "0x4040027")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x04040028 RID: 262184
		[Token(Token = "0x4040028")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04040029 RID: 262185
		[Token(Token = "0x4040029")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _soldText;

		// Token: 0x0404002A RID: 262186
		[Token(Token = "0x404002A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0404002B RID: 262187
		[Token(Token = "0x404002B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x0404002C RID: 262188
		[Token(Token = "0x404002C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x0404002D RID: 262189
		[Token(Token = "0x404002D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0404002E RID: 262190
		[Token(Token = "0x404002E")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isInited;

		// Token: 0x0404002F RID: 262191
		[Token(Token = "0x404002F")]
		[FieldOffset(Offset = "0x68")]
		private Action m_onClick;

		// Token: 0x04040030 RID: 262192
		[Token(Token = "0x4040030")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_costItem;

		// Token: 0x04040031 RID: 262193
		[Token(Token = "0x4040031")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_targetItem;

		// Token: 0x04040032 RID: 262194
		[Token(Token = "0x4040032")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_costModel;

		// Token: 0x04040033 RID: 262195
		[Token(Token = "0x4040033")]
		[FieldOffset(Offset = "0x88")]
		private UIItemViewModel m_targetModel;

		// Token: 0x04040034 RID: 262196
		[Token(Token = "0x4040034")]
		[FieldOffset(Offset = "0x90")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x04040035 RID: 262197
		[Token(Token = "0x4040035")]
		protected const float FADE_DURATION = 0.23f;

		// Token: 0x04040036 RID: 262198
		[Token(Token = "0x4040036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x04040037 RID: 262199
		[Token(Token = "0x4040037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04040038 RID: 262200
		[Token(Token = "0x4040038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderLockedPart;

		// Token: 0x04040039 RID: 262201
		[Token(Token = "0x4040039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0404003A RID: 262202
		[Token(Token = "0x404003A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0404003B RID: 262203
		[Token(Token = "0x404003B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0404003C RID: 262204
		[Token(Token = "0x404003C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBackImage;

		// Token: 0x0404003D RID: 262205
		[Token(Token = "0x404003D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderLockedPart;

		// Token: 0x0404003E RID: 262206
		[Token(Token = "0x404003E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0404003F RID: 262207
		[Token(Token = "0x404003F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04040040 RID: 262208
		[Token(Token = "0x4040040")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
