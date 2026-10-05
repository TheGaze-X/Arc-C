using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003778 RID: 14200
	[Token(Token = "0x2003778")]
	public class CancelDragIfFits : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601689E RID: 92318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601689E")]
		[Address(RVA = "0xEF20B0", Offset = "0xEF0CB0", VA = "0x180EF20B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0601689F RID: 92319 RVA: 0x00091908 File Offset: 0x0008FB08
		// (set) Token: 0x060168A0 RID: 92320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035FC")]
		public bool isLocked
		{
			[Token(Token = "0x601689F")]
			[Address(RVA = "0xEF29E0", Offset = "0xEF15E0", VA = "0x180EF29E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60168A0")]
			[Address(RVA = "0xEF2A40", Offset = "0xEF1640", VA = "0x180EF2A40")]
			private set
			{
			}
		}

		// Token: 0x060168A1 RID: 92321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A1")]
		[Address(RVA = "0xEF2050", Offset = "0xEF0C50", VA = "0x180EF2050")]
		public void UpdateLockState()
		{
		}

		// Token: 0x060168A2 RID: 92322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A2")]
		[Address(RVA = "0xEF2690", Offset = "0xEF1290", VA = "0x180EF2690")]
		private void _UpdateLockState()
		{
		}

		// Token: 0x060168A3 RID: 92323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A3")]
		[Address(RVA = "0xEF2420", Offset = "0xEF1020", VA = "0x180EF2420")]
		private void _UpdateArrowState(Vector2 size)
		{
		}

		// Token: 0x060168A4 RID: 92324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A4")]
		[Address(RVA = "0xEF2390", Offset = "0xEF0F90", VA = "0x180EF2390")]
		private void _OnValueChanged(Vector2 size)
		{
		}

		// Token: 0x060168A5 RID: 92325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A5")]
		[Address(RVA = "0xEF22A0", Offset = "0xEF0EA0", VA = "0x180EF22A0")]
		private void _OnContentLayoutRebuilt()
		{
		}

		// Token: 0x060168A6 RID: 92326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A6")]
		[Address(RVA = "0xEF1FA0", Offset = "0xEF0BA0", VA = "0x180EF1FA0")]
		private void Start()
		{
		}

		// Token: 0x060168A7 RID: 92327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A7")]
		[Address(RVA = "0xEF2970", Offset = "0xEF1570", VA = "0x180EF2970")]
		public CancelDragIfFits()
		{
		}

		// Token: 0x0401B282 RID: 111234
		[Token(Token = "0x401B282")]
		[FieldOffset(Offset = "0x18")]
		private float CONST_DELTA;

		// Token: 0x0401B283 RID: 111235
		[Token(Token = "0x401B283")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _disableTargetIfCancel;

		// Token: 0x0401B284 RID: 111236
		[Token(Token = "0x401B284")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _topArrow;

		// Token: 0x0401B285 RID: 111237
		[Token(Token = "0x401B285")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _downArrow;

		// Token: 0x0401B286 RID: 111238
		[Token(Token = "0x401B286")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0401B287 RID: 111239
		[Token(Token = "0x401B287")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0401B288 RID: 111240
		[Token(Token = "0x401B288")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isLocked;

		// Token: 0x0401B289 RID: 111241
		[Token(Token = "0x401B289")]
		[FieldOffset(Offset = "0x50")]
		private UIWrappedScrollRect.Wrapper m_scrollRect;

		// Token: 0x0401B28A RID: 111242
		[Token(Token = "0x401B28A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_originScrollVertical;

		// Token: 0x0401B28B RID: 111243
		[Token(Token = "0x401B28B")]
		[FieldOffset(Offset = "0x59")]
		private bool m_originScrollHorizontal;

		// Token: 0x0401B28C RID: 111244
		[Token(Token = "0x401B28C")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_isInited;

		// Token: 0x0401B28D RID: 111245
		[Token(Token = "0x401B28D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B28E RID: 111246
		[Token(Token = "0x401B28E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x0401B28F RID: 111247
		[Token(Token = "0x401B28F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isLocked;

		// Token: 0x0401B290 RID: 111248
		[Token(Token = "0x401B290")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateLockState;

		// Token: 0x0401B291 RID: 111249
		[Token(Token = "0x401B291")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateLockState;

		// Token: 0x0401B292 RID: 111250
		[Token(Token = "0x401B292")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateArrowState;

		// Token: 0x0401B293 RID: 111251
		[Token(Token = "0x401B293")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401B294 RID: 111252
		[Token(Token = "0x401B294")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnContentLayoutRebuilt;

		// Token: 0x0401B295 RID: 111253
		[Token(Token = "0x401B295")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B296 RID: 111254
		[Token(Token = "0x401B296")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
