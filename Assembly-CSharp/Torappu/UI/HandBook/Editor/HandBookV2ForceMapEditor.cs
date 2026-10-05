using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006740 RID: 26432
	[Token(Token = "0x2006740")]
	public class HandBookV2ForceMapEditor : SingletonMonoBehaviour<HandBookV2ForceMapEditor>
	{
		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x06025E92 RID: 155282 RVA: 0x000C9720 File Offset: 0x000C7920
		[Token(Token = "0x170059CB")]
		public OpEnum currentOp
		{
			[Token(Token = "0x6025E92")]
			[Address(RVA = "0x20DE140", Offset = "0x20DCD40", VA = "0x1820DE140")]
			get
			{
				return OpEnum.None;
			}
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x06025E93 RID: 155283 RVA: 0x000C9738 File Offset: 0x000C7938
		[Token(Token = "0x170059CC")]
		public bool isConfirmState
		{
			[Token(Token = "0x6025E93")]
			[Address(RVA = "0x20DE1A0", Offset = "0x20DCDA0", VA = "0x1820DE1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025E94 RID: 155284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E94")]
		[Address(RVA = "0x20DDC50", Offset = "0x20DC850", VA = "0x1820DDC50")]
		protected void Update()
		{
		}

		// Token: 0x06025E95 RID: 155285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E95")]
		[Address(RVA = "0x20DD0C0", Offset = "0x20DBCC0", VA = "0x1820DD0C0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06025E96 RID: 155286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E96")]
		[Address(RVA = "0x20DDD80", Offset = "0x20DC980", VA = "0x1820DDD80")]
		private void _InitData()
		{
		}

		// Token: 0x06025E97 RID: 155287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E97")]
		[Address(RVA = "0x20DE070", Offset = "0x20DCC70", VA = "0x1820DE070")]
		private void _SaveDataToFile()
		{
		}

		// Token: 0x06025E98 RID: 155288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E98")]
		[Address(RVA = "0x20DC570", Offset = "0x20DB170", VA = "0x1820DC570")]
		public void EnterConfirm(OpEnum opEnum = OpEnum.None)
		{
		}

		// Token: 0x06025E99 RID: 155289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E99")]
		[Address(RVA = "0x20DDA30", Offset = "0x20DC630", VA = "0x1820DDA30")]
		public void SelectForce(int forceIndex)
		{
		}

		// Token: 0x06025E9A RID: 155290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9A")]
		[Address(RVA = "0x20DDAC0", Offset = "0x20DC6C0", VA = "0x1820DDAC0")]
		public void SelectPoint(int pointIndex)
		{
		}

		// Token: 0x06025E9B RID: 155291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9B")]
		[Address(RVA = "0x20DDB40", Offset = "0x20DC740", VA = "0x1820DDB40")]
		public void SetPosInput(Vector2 pos)
		{
		}

		// Token: 0x06025E9C RID: 155292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9C")]
		[Address(RVA = "0x20DDBD0", Offset = "0x20DC7D0", VA = "0x1820DDBD0")]
		public void SetSliderVal(float val)
		{
		}

		// Token: 0x06025E9D RID: 155293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9D")]
		[Address(RVA = "0x20DD9C0", Offset = "0x20DC5C0", VA = "0x1820DD9C0")]
		public void QuitConfirm()
		{
		}

		// Token: 0x06025E9E RID: 155294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9E")]
		[Address(RVA = "0x20DC3E0", Offset = "0x20DAFE0", VA = "0x1820DC3E0")]
		public void ChangeOp(OpEnum opEnum)
		{
		}

		// Token: 0x06025E9F RID: 155295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E9F")]
		[Address(RVA = "0x20DCC10", Offset = "0x20DB810", VA = "0x1820DCC10")]
		public void OnCancelClick()
		{
		}

		// Token: 0x06025EA0 RID: 155296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA0")]
		[Address(RVA = "0x20DD650", Offset = "0x20DC250", VA = "0x1820DD650")]
		public void OnSureClick()
		{
		}

		// Token: 0x06025EA1 RID: 155297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA1")]
		[Address(RVA = "0x20DCE30", Offset = "0x20DBA30", VA = "0x1820DCE30")]
		public void OnDeleteForceLineClick()
		{
		}

		// Token: 0x06025EA2 RID: 155298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA2")]
		[Address(RVA = "0x20DCF70", Offset = "0x20DBB70", VA = "0x1820DCF70")]
		public void OnDeletePointLineClick()
		{
		}

		// Token: 0x06025EA3 RID: 155299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA3")]
		[Address(RVA = "0x20DC870", Offset = "0x20DB470", VA = "0x1820DC870")]
		public void OnAddForceClick()
		{
		}

		// Token: 0x06025EA4 RID: 155300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA4")]
		[Address(RVA = "0x20DCDA0", Offset = "0x20DB9A0", VA = "0x1820DCDA0")]
		public void OnDeleteForceClick()
		{
		}

		// Token: 0x06025EA5 RID: 155301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA5")]
		[Address(RVA = "0x20DC940", Offset = "0x20DB540", VA = "0x1820DC940")]
		public void OnAddForceLineClick()
		{
		}

		// Token: 0x06025EA6 RID: 155302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA6")]
		[Address(RVA = "0x20DD8C0", Offset = "0x20DC4C0", VA = "0x1820DD8C0")]
		public void OnZoomChanged(float zoomVal)
		{
		}

		// Token: 0x06025EA7 RID: 155303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA7")]
		[Address(RVA = "0x20DD300", Offset = "0x20DBF00", VA = "0x1820DD300")]
		public void OnOpChanged(int opVal)
		{
		}

		// Token: 0x06025EA8 RID: 155304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA8")]
		[Address(RVA = "0x20DD380", Offset = "0x20DBF80", VA = "0x1820DD380")]
		public void OnSaveClick()
		{
		}

		// Token: 0x06025EA9 RID: 155305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EA9")]
		[Address(RVA = "0x20DC9B0", Offset = "0x20DB5B0", VA = "0x1820DC9B0")]
		public void OnBgStyleToggle(bool isSolid)
		{
		}

		// Token: 0x06025EAA RID: 155306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAA")]
		[Address(RVA = "0x20DD7C0", Offset = "0x20DC3C0", VA = "0x1820DD7C0")]
		public void OnXInputChanged(string text)
		{
		}

		// Token: 0x06025EAB RID: 155307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAB")]
		[Address(RVA = "0x20DD840", Offset = "0x20DC440", VA = "0x1820DD840")]
		public void OnYInputChanged(string text)
		{
		}

		// Token: 0x06025EAC RID: 155308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAC")]
		[Address(RVA = "0x20DCD20", Offset = "0x20DB920", VA = "0x1820DCD20")]
		public void OnColorChanged(string text)
		{
		}

		// Token: 0x06025EAD RID: 155309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAD")]
		[Address(RVA = "0x20DCCA0", Offset = "0x20DB8A0", VA = "0x1820DCCA0")]
		public void OnCardColorChanged(string text)
		{
		}

		// Token: 0x06025EAE RID: 155310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAE")]
		[Address(RVA = "0x20DD410", Offset = "0x20DC010", VA = "0x1820DD410")]
		public void OnScaleChanged(string text)
		{
		}

		// Token: 0x06025EAF RID: 155311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EAF")]
		[Address(RVA = "0x20DCA40", Offset = "0x20DB640", VA = "0x1820DCA40")]
		public void OnBtnAlignClick()
		{
		}

		// Token: 0x06025EB0 RID: 155312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EB0")]
		[Address(RVA = "0x20DDFA0", Offset = "0x20DCBA0", VA = "0x1820DDFA0")]
		private void _OnInputChanged(string text, bool isXInput)
		{
		}

		// Token: 0x06025EB1 RID: 155313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EB1")]
		[Address(RVA = "0x20DDF30", Offset = "0x20DCB30", VA = "0x1820DDF30")]
		private void _OnColorChanged()
		{
		}

		// Token: 0x06025EB2 RID: 155314 RVA: 0x000C9750 File Offset: 0x000C7950
		[Token(Token = "0x6025EB2")]
		[Address(RVA = "0x20DC600", Offset = "0x20DB200", VA = "0x1820DC600")]
		public int GetMaxForceIndex()
		{
			return 0;
		}

		// Token: 0x06025EB3 RID: 155315 RVA: 0x000C9768 File Offset: 0x000C7968
		[Token(Token = "0x6025EB3")]
		[Address(RVA = "0x20DC6F0", Offset = "0x20DB2F0", VA = "0x1820DC6F0")]
		public int GetMaxPointIndex()
		{
			return 0;
		}

		// Token: 0x06025EB4 RID: 155316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EB4")]
		[Address(RVA = "0x20DE0D0", Offset = "0x20DCCD0", VA = "0x1820DE0D0")]
		public HandBookV2ForceMapEditor()
		{
		}

		// Token: 0x040354EE RID: 218350
		[Token(Token = "0x40354EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2ForceMapDB _forceMapDB;

		// Token: 0x040354EF RID: 218351
		[Token(Token = "0x40354EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2ForceMapEditorView _mapView;

		// Token: 0x040354F0 RID: 218352
		[Token(Token = "0x40354F0")]
		[FieldOffset(Offset = "0x28")]
		private HandBookV2ForceMapData m_forceMapData;

		// Token: 0x040354F1 RID: 218353
		[Token(Token = "0x40354F1")]
		[FieldOffset(Offset = "0x30")]
		private HandBookV2ForceMapEditorModel m_editorModel;

		// Token: 0x040354F2 RID: 218354
		[Token(Token = "0x40354F2")]
		[FieldOffset(Offset = "0x38")]
		private HandBookV2ForceMapEditorProperty m_editorProperty;

		// Token: 0x040354F3 RID: 218355
		[Token(Token = "0x40354F3")]
		[FieldOffset(Offset = "0x40")]
		private OpEnum m_op;

		// Token: 0x040354F4 RID: 218356
		[Token(Token = "0x40354F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentOp;

		// Token: 0x040354F5 RID: 218357
		[Token(Token = "0x40354F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isConfirmState;

		// Token: 0x040354F6 RID: 218358
		[Token(Token = "0x40354F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040354F7 RID: 218359
		[Token(Token = "0x40354F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040354F8 RID: 218360
		[Token(Token = "0x40354F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x040354F9 RID: 218361
		[Token(Token = "0x40354F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SaveDataToFile;

		// Token: 0x040354FA RID: 218362
		[Token(Token = "0x40354FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EnterConfirm;

		// Token: 0x040354FB RID: 218363
		[Token(Token = "0x40354FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectForce;

		// Token: 0x040354FC RID: 218364
		[Token(Token = "0x40354FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectPoint;

		// Token: 0x040354FD RID: 218365
		[Token(Token = "0x40354FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetPosInput;

		// Token: 0x040354FE RID: 218366
		[Token(Token = "0x40354FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetSliderVal;

		// Token: 0x040354FF RID: 218367
		[Token(Token = "0x40354FF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_QuitConfirm;

		// Token: 0x04035500 RID: 218368
		[Token(Token = "0x4035500")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ChangeOp;

		// Token: 0x04035501 RID: 218369
		[Token(Token = "0x4035501")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x04035502 RID: 218370
		[Token(Token = "0x4035502")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSureClick;

		// Token: 0x04035503 RID: 218371
		[Token(Token = "0x4035503")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDeleteForceLineClick;

		// Token: 0x04035504 RID: 218372
		[Token(Token = "0x4035504")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDeletePointLineClick;

		// Token: 0x04035505 RID: 218373
		[Token(Token = "0x4035505")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnAddForceClick;

		// Token: 0x04035506 RID: 218374
		[Token(Token = "0x4035506")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDeleteForceClick;

		// Token: 0x04035507 RID: 218375
		[Token(Token = "0x4035507")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnAddForceLineClick;

		// Token: 0x04035508 RID: 218376
		[Token(Token = "0x4035508")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnZoomChanged;

		// Token: 0x04035509 RID: 218377
		[Token(Token = "0x4035509")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnOpChanged;

		// Token: 0x0403550A RID: 218378
		[Token(Token = "0x403550A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnSaveClick;

		// Token: 0x0403550B RID: 218379
		[Token(Token = "0x403550B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnBgStyleToggle;

		// Token: 0x0403550C RID: 218380
		[Token(Token = "0x403550C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnXInputChanged;

		// Token: 0x0403550D RID: 218381
		[Token(Token = "0x403550D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnYInputChanged;

		// Token: 0x0403550E RID: 218382
		[Token(Token = "0x403550E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnColorChanged;

		// Token: 0x0403550F RID: 218383
		[Token(Token = "0x403550F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnCardColorChanged;

		// Token: 0x04035510 RID: 218384
		[Token(Token = "0x4035510")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnScaleChanged;

		// Token: 0x04035511 RID: 218385
		[Token(Token = "0x4035511")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnBtnAlignClick;

		// Token: 0x04035512 RID: 218386
		[Token(Token = "0x4035512")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnInputChanged;

		// Token: 0x04035513 RID: 218387
		[Token(Token = "0x4035513")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnColorChanged;

		// Token: 0x04035514 RID: 218388
		[Token(Token = "0x4035514")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetMaxForceIndex;

		// Token: 0x04035515 RID: 218389
		[Token(Token = "0x4035515")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetMaxPointIndex;

		// Token: 0x04035516 RID: 218390
		[Token(Token = "0x4035516")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
