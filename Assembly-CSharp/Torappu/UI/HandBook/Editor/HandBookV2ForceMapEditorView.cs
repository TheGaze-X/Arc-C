using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006743 RID: 26435
	[Token(Token = "0x2006743")]
	public class HandBookV2ForceMapEditorView : DataBinder<HandBookV2ForceMapEditorProperty>
	{
		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x06025EB7 RID: 155319 RVA: 0x000C9780 File Offset: 0x000C7980
		[Token(Token = "0x170059CD")]
		public int selectForceIndex
		{
			[Token(Token = "0x6025EB7")]
			[Address(RVA = "0x20DC380", Offset = "0x20DAF80", VA = "0x1820DC380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x06025EB8 RID: 155320 RVA: 0x000C9798 File Offset: 0x000C7998
		[Token(Token = "0x170059CE")]
		public bool isConfirmState
		{
			[Token(Token = "0x6025EB8")]
			[Address(RVA = "0x20DC320", Offset = "0x20DAF20", VA = "0x1820DC320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025EB9 RID: 155321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EB9")]
		[Address(RVA = "0x20D4E80", Offset = "0x20D3A80", VA = "0x1820D4E80", Slot = "7")]
		public override void OnValueChanged(HandBookV2ForceMapEditorProperty property)
		{
		}

		// Token: 0x06025EBA RID: 155322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBA")]
		[Address(RVA = "0x20DB9D0", Offset = "0x20DA5D0", VA = "0x1820DB9D0")]
		private void _UpdateForceDropDown()
		{
		}

		// Token: 0x06025EBB RID: 155323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBB")]
		[Address(RVA = "0x20D9B40", Offset = "0x20D8740", VA = "0x1820D9B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025EBC RID: 155324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBC")]
		[Address(RVA = "0x20DA290", Offset = "0x20D8E90", VA = "0x1820DA290")]
		private void _RenderForce(HandBookV2ForceData forceData, bool isTemp = false)
		{
		}

		// Token: 0x06025EBD RID: 155325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBD")]
		[Address(RVA = "0x20D9E90", Offset = "0x20D8A90", VA = "0x1820D9E90")]
		private void _RenderCard(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025EBE RID: 155326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBE")]
		[Address(RVA = "0x20DA010", Offset = "0x20D8C10", VA = "0x1820DA010")]
		private void _RenderForceLine(int index, HandBookV2ForceLineData lineData)
		{
		}

		// Token: 0x06025EBF RID: 155327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EBF")]
		[Address(RVA = "0x20DA430", Offset = "0x20D9030", VA = "0x1820DA430")]
		private void _RenderPointLine(int index, HandBookV2PointLineData lineData)
		{
		}

		// Token: 0x06025EC0 RID: 155328 RVA: 0x000C97B0 File Offset: 0x000C79B0
		[Token(Token = "0x6025EC0")]
		[Address(RVA = "0x20D99A0", Offset = "0x20D85A0", VA = "0x1820D99A0")]
		private Vector2 _GetPointPos(int pointIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06025EC1 RID: 155329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC1")]
		[Address(RVA = "0x20DB130", Offset = "0x20D9D30", VA = "0x1820DB130")]
		private void _SetPreviewLineActive(bool isActive)
		{
		}

		// Token: 0x06025EC2 RID: 155330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC2")]
		[Address(RVA = "0x20DAEC0", Offset = "0x20D9AC0", VA = "0x1820DAEC0")]
		private void _SetOpDropdownActive(bool isActive)
		{
		}

		// Token: 0x06025EC3 RID: 155331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC3")]
		[Address(RVA = "0x20DACC0", Offset = "0x20D98C0", VA = "0x1820DACC0")]
		private void _SetConfirmPanelActive(bool isActive)
		{
		}

		// Token: 0x06025EC4 RID: 155332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC4")]
		[Address(RVA = "0x20DB1C0", Offset = "0x20D9DC0", VA = "0x1820DB1C0")]
		private void _SetSavePanelActive(bool isActive)
		{
		}

		// Token: 0x06025EC5 RID: 155333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC5")]
		[Address(RVA = "0x20DB240", Offset = "0x20D9E40", VA = "0x1820DB240")]
		private void _SetScaleSliderActive(bool isActive)
		{
		}

		// Token: 0x06025EC6 RID: 155334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC6")]
		[Address(RVA = "0x20DB0B0", Offset = "0x20D9CB0", VA = "0x1820DB0B0")]
		private void _SetPosInputActive(bool isActive)
		{
		}

		// Token: 0x06025EC7 RID: 155335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC7")]
		[Address(RVA = "0x20DAC40", Offset = "0x20D9840", VA = "0x1820DAC40")]
		private void _SetColorInputActive(bool isActive)
		{
		}

		// Token: 0x06025EC8 RID: 155336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC8")]
		[Address(RVA = "0x20DABC0", Offset = "0x20D97C0", VA = "0x1820DABC0")]
		private void _SetAddForceLinePanelActive(bool isActive)
		{
		}

		// Token: 0x06025EC9 RID: 155337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EC9")]
		[Address(RVA = "0x20DA8E0", Offset = "0x20D94E0", VA = "0x1820DA8E0")]
		private void _ResetTextPoint()
		{
		}

		// Token: 0x06025ECA RID: 155338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECA")]
		[Address(RVA = "0x20D8180", Offset = "0x20D6D80", VA = "0x1820D8180")]
		public void SetForceLineListPanelActive(bool isActive)
		{
		}

		// Token: 0x06025ECB RID: 155339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECB")]
		[Address(RVA = "0x20D84A0", Offset = "0x20D70A0", VA = "0x1820D84A0")]
		public void SetPointLineListPanelActive(bool isActive)
		{
		}

		// Token: 0x06025ECC RID: 155340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECC")]
		[Address(RVA = "0x20D8200", Offset = "0x20D6E00", VA = "0x1820D8200")]
		public void SetForceListPanelActive(bool isActive)
		{
		}

		// Token: 0x06025ECD RID: 155341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECD")]
		[Address(RVA = "0x20D8280", Offset = "0x20D6E80", VA = "0x1820D8280")]
		public void SetForceSelectPanelActive(bool isActive)
		{
		}

		// Token: 0x06025ECE RID: 155342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECE")]
		[Address(RVA = "0x20D85F0", Offset = "0x20D71F0", VA = "0x1820D85F0")]
		public void SetSliderVal(float val)
		{
		}

		// Token: 0x06025ECF RID: 155343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ECF")]
		[Address(RVA = "0x20D8520", Offset = "0x20D7120", VA = "0x1820D8520")]
		public void SetPosInput(Vector2 pos)
		{
		}

		// Token: 0x06025ED0 RID: 155344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED0")]
		[Address(RVA = "0x20D80C0", Offset = "0x20D6CC0", VA = "0x1820D80C0")]
		public void SetColorVal(string colorStr, string cardColorStr)
		{
		}

		// Token: 0x06025ED1 RID: 155345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED1")]
		[Address(RVA = "0x20D5AD0", Offset = "0x20D46D0", VA = "0x1820D5AD0")]
		public void QuitConfirm(OpEnum opEnum)
		{
		}

		// Token: 0x06025ED2 RID: 155346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED2")]
		[Address(RVA = "0x20D43B0", Offset = "0x20D2FB0", VA = "0x1820D43B0")]
		public void EnterConfirm(OpEnum opEnum)
		{
		}

		// Token: 0x06025ED3 RID: 155347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED3")]
		[Address(RVA = "0x20D9650", Offset = "0x20D8250", VA = "0x1820D9650")]
		private void _ClearLineMap()
		{
		}

		// Token: 0x06025ED4 RID: 155348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED4")]
		[Address(RVA = "0x20D9300", Offset = "0x20D7F00", VA = "0x1820D9300")]
		private void _ClearForceMap()
		{
		}

		// Token: 0x06025ED5 RID: 155349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED5")]
		[Address(RVA = "0x20D7130", Offset = "0x20D5D30", VA = "0x1820D7130")]
		public void SelectForceLine(int lineIdx)
		{
		}

		// Token: 0x06025ED6 RID: 155350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED6")]
		[Address(RVA = "0x20D4040", Offset = "0x20D2C40", VA = "0x1820D4040")]
		public void ClearSelectForceLine()
		{
		}

		// Token: 0x06025ED7 RID: 155351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED7")]
		[Address(RVA = "0x20D4330", Offset = "0x20D2F30", VA = "0x1820D4330")]
		public void ClearSelectPointLine()
		{
		}

		// Token: 0x06025ED8 RID: 155352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED8")]
		[Address(RVA = "0x20D40C0", Offset = "0x20D2CC0", VA = "0x1820D40C0")]
		public void ClearSelectForce()
		{
		}

		// Token: 0x06025ED9 RID: 155353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ED9")]
		[Address(RVA = "0x20D7580", Offset = "0x20D6180", VA = "0x1820D7580")]
		public void SelectPointLine(int lineIdx)
		{
		}

		// Token: 0x06025EDA RID: 155354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDA")]
		[Address(RVA = "0x20D76B0", Offset = "0x20D62B0", VA = "0x1820D76B0")]
		public void SelectPoint(int pointIndex)
		{
		}

		// Token: 0x06025EDB RID: 155355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDB")]
		[Address(RVA = "0x20DA9E0", Offset = "0x20D95E0", VA = "0x1820DA9E0")]
		public void _SelectPoint(int pointIdx, bool isSelected)
		{
		}

		// Token: 0x06025EDC RID: 155356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDC")]
		[Address(RVA = "0x20DAF50", Offset = "0x20D9B50", VA = "0x1820DAF50")]
		public void _SetPointLineVertText(int pointIndex, bool isPoint1)
		{
		}

		// Token: 0x06025EDD RID: 155357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDD")]
		[Address(RVA = "0x20D7310", Offset = "0x20D5F10", VA = "0x1820D7310")]
		public void SelectForce(int forceIndex, OpEnum opEnum)
		{
		}

		// Token: 0x06025EDE RID: 155358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDE")]
		[Address(RVA = "0x20DB2D0", Offset = "0x20D9ED0", VA = "0x1820DB2D0")]
		private void _SetSelectForce(int forceIndex, OpEnum m_op, bool isSelected)
		{
		}

		// Token: 0x06025EDF RID: 155359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EDF")]
		[Address(RVA = "0x20DAD40", Offset = "0x20D9940", VA = "0x1820DAD40")]
		private void _SetLineVertText(int forceIndex, bool isPoint1)
		{
		}

		// Token: 0x06025EE0 RID: 155360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE0")]
		[Address(RVA = "0x20D8E00", Offset = "0x20D7A00", VA = "0x1820D8E00")]
		public void UpdateLogoScale(float scale)
		{
		}

		// Token: 0x06025EE1 RID: 155361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE1")]
		[Address(RVA = "0x20D8940", Offset = "0x20D7540", VA = "0x1820D8940")]
		public void UpdateCardScale(float scaleVal)
		{
		}

		// Token: 0x06025EE2 RID: 155362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE2")]
		[Address(RVA = "0x20DB750", Offset = "0x20DA350", VA = "0x1820DB750")]
		private void _UpdateBgPos(float inputVal, bool isXInput)
		{
		}

		// Token: 0x06025EE3 RID: 155363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE3")]
		[Address(RVA = "0x20DB890", Offset = "0x20DA490", VA = "0x1820DB890")]
		private void _UpdateCardPos(float val, bool isX)
		{
		}

		// Token: 0x06025EE4 RID: 155364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE4")]
		[Address(RVA = "0x20DBE40", Offset = "0x20DAA40", VA = "0x1820DBE40")]
		private void _UpdateLogoPos(float val, bool isX)
		{
		}

		// Token: 0x06025EE5 RID: 155365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE5")]
		[Address(RVA = "0x20D8EF0", Offset = "0x20D7AF0", VA = "0x1820D8EF0")]
		public void UpdatePos(OpEnum op, float val, bool isXInput)
		{
		}

		// Token: 0x06025EE6 RID: 155366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE6")]
		[Address(RVA = "0x20D8A30", Offset = "0x20D7630", VA = "0x1820D8A30")]
		public void UpdateColor()
		{
		}

		// Token: 0x06025EE7 RID: 155367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE7")]
		[Address(RVA = "0x20D3E10", Offset = "0x20D2A10", VA = "0x1820D3E10")]
		public void AlignInputPos(OpEnum op)
		{
		}

		// Token: 0x06025EE8 RID: 155368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE8")]
		[Address(RVA = "0x20D8720", Offset = "0x20D7320", VA = "0x1820D8720")]
		public void ToggleBgStyle(bool isSolid)
		{
		}

		// Token: 0x06025EE9 RID: 155369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EE9")]
		[Address(RVA = "0x20D9250", Offset = "0x20D7E50", VA = "0x1820D9250")]
		public void ZoomView(float zoomVal)
		{
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EEA")]
		[Address(RVA = "0x20D3F80", Offset = "0x20D2B80", VA = "0x1820D3F80")]
		public void ChangeOpMode(OpEnum opEnum)
		{
		}

		// Token: 0x06025EEB RID: 155371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EEB")]
		[Address(RVA = "0x20D46B0", Offset = "0x20D32B0", VA = "0x1820D46B0")]
		public void FocusOnPos(Vector2 pos)
		{
		}

		// Token: 0x06025EEC RID: 155372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EEC")]
		[Address(RVA = "0x20D7DA0", Offset = "0x20D69A0", VA = "0x1820D7DA0")]
		public void SetBgRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025EED RID: 155373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EED")]
		[Address(RVA = "0x20D8300", Offset = "0x20D6F00", VA = "0x1820D8300")]
		public void SetLogoRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025EEE RID: 155374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EEE")]
		[Address(RVA = "0x20D7F40", Offset = "0x20D6B40", VA = "0x1820D7F40")]
		public void SetCardRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025EEF RID: 155375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EEF")]
		[Address(RVA = "0x20D8680", Offset = "0x20D7280", VA = "0x1820D8680")]
		public void SetViewportRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025EF0 RID: 155376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF0")]
		[Address(RVA = "0x20D7860", Offset = "0x20D6460", VA = "0x1820D7860")]
		public void SetAllCardVisible(bool isVisible)
		{
		}

		// Token: 0x06025EF1 RID: 155377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF1")]
		[Address(RVA = "0x20D79E0", Offset = "0x20D65E0", VA = "0x1820D79E0")]
		public void SetAllForceLineVisible(bool isVisible)
		{
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF2")]
		[Address(RVA = "0x20D7BC0", Offset = "0x20D67C0", VA = "0x1820D7BC0")]
		public void SetAllPointLineVisible(bool isVisible)
		{
		}

		// Token: 0x06025EF3 RID: 155379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF3")]
		[Address(RVA = "0x20D61F0", Offset = "0x20D4DF0", VA = "0x1820D61F0")]
		public void SaveBgModified()
		{
		}

		// Token: 0x06025EF4 RID: 155380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF4")]
		[Address(RVA = "0x20D6E90", Offset = "0x20D5A90", VA = "0x1820D6E90")]
		public void SaveLogoModified()
		{
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF5")]
		[Address(RVA = "0x20D6770", Offset = "0x20D5370", VA = "0x1820D6770")]
		public void SaveColorModified()
		{
		}

		// Token: 0x06025EF6 RID: 155382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF6")]
		[Address(RVA = "0x20D64D0", Offset = "0x20D50D0", VA = "0x1820D64D0")]
		public void SaveCardModified()
		{
		}

		// Token: 0x06025EF7 RID: 155383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF7")]
		[Address(RVA = "0x20D6C20", Offset = "0x20D5820", VA = "0x1820D6C20")]
		public void SaveForceShapeModified()
		{
		}

		// Token: 0x06025EF8 RID: 155384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF8")]
		[Address(RVA = "0x20D3720", Offset = "0x20D2320", VA = "0x1820D3720")]
		public void AddForceLine()
		{
		}

		// Token: 0x06025EF9 RID: 155385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EF9")]
		[Address(RVA = "0x20D5C60", Offset = "0x20D4860", VA = "0x1820D5C60")]
		public void RemoveForceLine()
		{
		}

		// Token: 0x06025EFA RID: 155386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EFA")]
		[Address(RVA = "0x20D3C20", Offset = "0x20D2820", VA = "0x1820D3C20")]
		public void AddPointLine()
		{
		}

		// Token: 0x06025EFB RID: 155387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EFB")]
		[Address(RVA = "0x20D6120", Offset = "0x20D4D20", VA = "0x1820D6120")]
		public void RemovePointLine()
		{
		}

		// Token: 0x06025EFC RID: 155388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EFC")]
		[Address(RVA = "0x20D5D30", Offset = "0x20D4930", VA = "0x1820D5D30")]
		public void RemoveForce()
		{
		}

		// Token: 0x06025EFD RID: 155389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EFD")]
		[Address(RVA = "0x20D39E0", Offset = "0x20D25E0", VA = "0x1820D39E0")]
		public void AddNewForce()
		{
		}

		// Token: 0x06025EFE RID: 155390 RVA: 0x000C97C8 File Offset: 0x000C79C8
		[Token(Token = "0x6025EFE")]
		[Address(RVA = "0x20D4790", Offset = "0x20D3390", VA = "0x1820D4790")]
		private Vector2 GetClickPos()
		{
			return default(Vector2);
		}

		// Token: 0x06025EFF RID: 155391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025EFF")]
		[Address(RVA = "0x20D4860", Offset = "0x20D3460", VA = "0x1820D4860")]
		public void OnClick()
		{
		}

		// Token: 0x06025F00 RID: 155392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F00")]
		[Address(RVA = "0x20DBF90", Offset = "0x20DAB90", VA = "0x1820DBF90")]
		public HandBookV2ForceMapEditorView()
		{
		}

		// Token: 0x04035518 RID: 218392
		[Token(Token = "0x4035518")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2EditorForceView _forceViewTemplate;

		// Token: 0x04035519 RID: 218393
		[Token(Token = "0x4035519")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _forceViewContainer;

		// Token: 0x0403551A RID: 218394
		[Token(Token = "0x403551A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookV2EditorForceCardView _forceCardTemplate;

		// Token: 0x0403551B RID: 218395
		[Token(Token = "0x403551B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _forceCardContainer;

		// Token: 0x0403551C RID: 218396
		[Token(Token = "0x403551C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandBookV2EditorForceLineView _forceLineTemplate;

		// Token: 0x0403551D RID: 218397
		[Token(Token = "0x403551D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _forceLineContainer;

		// Token: 0x0403551E RID: 218398
		[Token(Token = "0x403551E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HandBookV2EditorPointLineView _pointLineTemplate;

		// Token: 0x0403551F RID: 218399
		[Token(Token = "0x403551F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _pointLineContainer;

		// Token: 0x04035520 RID: 218400
		[Token(Token = "0x4035520")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _contentRt;

		// Token: 0x04035521 RID: 218401
		[Token(Token = "0x4035521")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private NonDrawingGraphic _contentRaycast;

		// Token: 0x04035522 RID: 218402
		[Token(Token = "0x4035522")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _confirmPanelGo;

		// Token: 0x04035523 RID: 218403
		[Token(Token = "0x4035523")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _scaleInput;

		// Token: 0x04035524 RID: 218404
		[Token(Token = "0x4035524")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Dropdown _opDropdown;

		// Token: 0x04035525 RID: 218405
		[Token(Token = "0x4035525")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _savePanelGo;

		// Token: 0x04035526 RID: 218406
		[Token(Token = "0x4035526")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _positionInputPanel;

		// Token: 0x04035527 RID: 218407
		[Token(Token = "0x4035527")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _colorInputPanel;

		// Token: 0x04035528 RID: 218408
		[Token(Token = "0x4035528")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private InputField _xInput;

		// Token: 0x04035529 RID: 218409
		[Token(Token = "0x4035529")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private InputField _yInput;

		// Token: 0x0403552A RID: 218410
		[Token(Token = "0x403552A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private InputField _colorInput;

		// Token: 0x0403552B RID: 218411
		[Token(Token = "0x403552B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private InputField _cardColorInput;

		// Token: 0x0403552C RID: 218412
		[Token(Token = "0x403552C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _forceLineListPanel;

		// Token: 0x0403552D RID: 218413
		[Token(Token = "0x403552D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private SimpleLayoutContent _forceLineList;

		// Token: 0x0403552E RID: 218414
		[Token(Token = "0x403552E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _pointLineListPanel;

		// Token: 0x0403552F RID: 218415
		[Token(Token = "0x403552F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private SimpleLayoutContent _pointLineList;

		// Token: 0x04035530 RID: 218416
		[Token(Token = "0x4035530")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _addForceLinePanel;

		// Token: 0x04035531 RID: 218417
		[Token(Token = "0x4035531")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _textPoint1;

		// Token: 0x04035532 RID: 218418
		[Token(Token = "0x4035532")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _textPoint2;

		// Token: 0x04035533 RID: 218419
		[Token(Token = "0x4035533")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private HandBookV2EditorForceLineView _previewLine;

		// Token: 0x04035534 RID: 218420
		[Token(Token = "0x4035534")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _forceListPanel;

		// Token: 0x04035535 RID: 218421
		[Token(Token = "0x4035535")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private SimpleLayoutContent _forceList;

		// Token: 0x04035536 RID: 218422
		[Token(Token = "0x4035536")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _forceSelectPanel;

		// Token: 0x04035537 RID: 218423
		[Token(Token = "0x4035537")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Dropdown _forceDropdown;

		// Token: 0x04035538 RID: 218424
		[Token(Token = "0x4035538")]
		[FieldOffset(Offset = "0x120")]
		private bool m_hasInited;

		// Token: 0x04035539 RID: 218425
		[Token(Token = "0x4035539")]
		[FieldOffset(Offset = "0x121")]
		private bool m_isConfirmState;

		// Token: 0x0403553A RID: 218426
		[Token(Token = "0x403553A")]
		[FieldOffset(Offset = "0x128")]
		private HandBookV2ForceMapData m_forceMapData;

		// Token: 0x0403553B RID: 218427
		[Token(Token = "0x403553B")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<int, string> m_pointIdx2ForceIdMap;

		// Token: 0x0403553C RID: 218428
		[Token(Token = "0x403553C")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<string, HandBookV2ForceData> m_forceId2DataMap;

		// Token: 0x0403553D RID: 218429
		[Token(Token = "0x403553D")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<int, HandBookV2EditorForceView> m_forceIdx2ViewMap;

		// Token: 0x0403553E RID: 218430
		[Token(Token = "0x403553E")]
		[FieldOffset(Offset = "0x148")]
		private Dictionary<int, HandBookV2EditorForceCardView> m_forceIdx2CardMap;

		// Token: 0x0403553F RID: 218431
		[Token(Token = "0x403553F")]
		[FieldOffset(Offset = "0x150")]
		private Dictionary<int, HandBookV2EditorForceLineView> m_forceLineIdx2LineMap;

		// Token: 0x04035540 RID: 218432
		[Token(Token = "0x4035540")]
		[FieldOffset(Offset = "0x158")]
		private Dictionary<int, HandBookV2EditorPointLineView> m_pointLineIdx2LineMap;

		// Token: 0x04035541 RID: 218433
		[Token(Token = "0x4035541")]
		[FieldOffset(Offset = "0x160")]
		private List<string> m_candidateForceList;

		// Token: 0x04035542 RID: 218434
		[Token(Token = "0x4035542")]
		[FieldOffset(Offset = "0x168")]
		private HandBookV2ForceMapEditorView.Adapter m_forceLineListAdapter;

		// Token: 0x04035543 RID: 218435
		[Token(Token = "0x4035543")]
		[FieldOffset(Offset = "0x170")]
		private HandBookV2ForceMapEditorView.Adapter m_pointLineListAdapter;

		// Token: 0x04035544 RID: 218436
		[Token(Token = "0x4035544")]
		[FieldOffset(Offset = "0x178")]
		private HandBookV2ForceMapEditorView.Adapter m_forceListAdapter;

		// Token: 0x04035545 RID: 218437
		[Token(Token = "0x4035545")]
		[FieldOffset(Offset = "0x180")]
		private List<string> m_forceLineDataSource;

		// Token: 0x04035546 RID: 218438
		[Token(Token = "0x4035546")]
		[FieldOffset(Offset = "0x188")]
		private List<string> m_pointLineDataSource;

		// Token: 0x04035547 RID: 218439
		[Token(Token = "0x4035547")]
		[FieldOffset(Offset = "0x190")]
		private List<string> m_forceDataSource;

		// Token: 0x04035548 RID: 218440
		[Token(Token = "0x4035548")]
		private const string FORCE_NONE = "未指定";

		// Token: 0x04035549 RID: 218441
		[Token(Token = "0x4035549")]
		[FieldOffset(Offset = "0x198")]
		private int m_selectForceLineIndex;

		// Token: 0x0403554A RID: 218442
		[Token(Token = "0x403554A")]
		[FieldOffset(Offset = "0x19C")]
		private int m_selectPointLineIndex;

		// Token: 0x0403554B RID: 218443
		[Token(Token = "0x403554B")]
		[FieldOffset(Offset = "0x1A0")]
		private int m_selectPointIdx1;

		// Token: 0x0403554C RID: 218444
		[Token(Token = "0x403554C")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_selectPointIdx2;

		// Token: 0x0403554D RID: 218445
		[Token(Token = "0x403554D")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_selectForceIndex;

		// Token: 0x0403554E RID: 218446
		[Token(Token = "0x403554E")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_selectForceIndex2;

		// Token: 0x0403554F RID: 218447
		[Token(Token = "0x403554F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectForceIndex;

		// Token: 0x04035550 RID: 218448
		[Token(Token = "0x4035550")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isConfirmState;

		// Token: 0x04035551 RID: 218449
		[Token(Token = "0x4035551")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035552 RID: 218450
		[Token(Token = "0x4035552")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateForceDropDown;

		// Token: 0x04035553 RID: 218451
		[Token(Token = "0x4035553")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035554 RID: 218452
		[Token(Token = "0x4035554")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderForce;

		// Token: 0x04035555 RID: 218453
		[Token(Token = "0x4035555")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x04035556 RID: 218454
		[Token(Token = "0x4035556")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderForceLine;

		// Token: 0x04035557 RID: 218455
		[Token(Token = "0x4035557")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderPointLine;

		// Token: 0x04035558 RID: 218456
		[Token(Token = "0x4035558")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetPointPos;

		// Token: 0x04035559 RID: 218457
		[Token(Token = "0x4035559")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetPreviewLineActive;

		// Token: 0x0403555A RID: 218458
		[Token(Token = "0x403555A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetOpDropdownActive;

		// Token: 0x0403555B RID: 218459
		[Token(Token = "0x403555B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetConfirmPanelActive;

		// Token: 0x0403555C RID: 218460
		[Token(Token = "0x403555C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetSavePanelActive;

		// Token: 0x0403555D RID: 218461
		[Token(Token = "0x403555D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetScaleSliderActive;

		// Token: 0x0403555E RID: 218462
		[Token(Token = "0x403555E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetPosInputActive;

		// Token: 0x0403555F RID: 218463
		[Token(Token = "0x403555F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetColorInputActive;

		// Token: 0x04035560 RID: 218464
		[Token(Token = "0x4035560")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetAddForceLinePanelActive;

		// Token: 0x04035561 RID: 218465
		[Token(Token = "0x4035561")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ResetTextPoint;

		// Token: 0x04035562 RID: 218466
		[Token(Token = "0x4035562")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetForceLineListPanelActive;

		// Token: 0x04035563 RID: 218467
		[Token(Token = "0x4035563")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetPointLineListPanelActive;

		// Token: 0x04035564 RID: 218468
		[Token(Token = "0x4035564")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetForceListPanelActive;

		// Token: 0x04035565 RID: 218469
		[Token(Token = "0x4035565")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetForceSelectPanelActive;

		// Token: 0x04035566 RID: 218470
		[Token(Token = "0x4035566")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetSliderVal;

		// Token: 0x04035567 RID: 218471
		[Token(Token = "0x4035567")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetPosInput;

		// Token: 0x04035568 RID: 218472
		[Token(Token = "0x4035568")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetColorVal;

		// Token: 0x04035569 RID: 218473
		[Token(Token = "0x4035569")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_QuitConfirm;

		// Token: 0x0403556A RID: 218474
		[Token(Token = "0x403556A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EnterConfirm;

		// Token: 0x0403556B RID: 218475
		[Token(Token = "0x403556B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ClearLineMap;

		// Token: 0x0403556C RID: 218476
		[Token(Token = "0x403556C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ClearForceMap;

		// Token: 0x0403556D RID: 218477
		[Token(Token = "0x403556D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SelectForceLine;

		// Token: 0x0403556E RID: 218478
		[Token(Token = "0x403556E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ClearSelectForceLine;

		// Token: 0x0403556F RID: 218479
		[Token(Token = "0x403556F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ClearSelectPointLine;

		// Token: 0x04035570 RID: 218480
		[Token(Token = "0x4035570")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ClearSelectForce;

		// Token: 0x04035571 RID: 218481
		[Token(Token = "0x4035571")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SelectPointLine;

		// Token: 0x04035572 RID: 218482
		[Token(Token = "0x4035572")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SelectPoint;

		// Token: 0x04035573 RID: 218483
		[Token(Token = "0x4035573")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SelectPoint;

		// Token: 0x04035574 RID: 218484
		[Token(Token = "0x4035574")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SetPointLineVertText;

		// Token: 0x04035575 RID: 218485
		[Token(Token = "0x4035575")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SelectForce;

		// Token: 0x04035576 RID: 218486
		[Token(Token = "0x4035576")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SetSelectForce;

		// Token: 0x04035577 RID: 218487
		[Token(Token = "0x4035577")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SetLineVertText;

		// Token: 0x04035578 RID: 218488
		[Token(Token = "0x4035578")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_UpdateLogoScale;

		// Token: 0x04035579 RID: 218489
		[Token(Token = "0x4035579")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UpdateCardScale;

		// Token: 0x0403557A RID: 218490
		[Token(Token = "0x403557A")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__UpdateBgPos;

		// Token: 0x0403557B RID: 218491
		[Token(Token = "0x403557B")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__UpdateCardPos;

		// Token: 0x0403557C RID: 218492
		[Token(Token = "0x403557C")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__UpdateLogoPos;

		// Token: 0x0403557D RID: 218493
		[Token(Token = "0x403557D")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_UpdatePos;

		// Token: 0x0403557E RID: 218494
		[Token(Token = "0x403557E")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_UpdateColor;

		// Token: 0x0403557F RID: 218495
		[Token(Token = "0x403557F")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_AlignInputPos;

		// Token: 0x04035580 RID: 218496
		[Token(Token = "0x4035580")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ToggleBgStyle;

		// Token: 0x04035581 RID: 218497
		[Token(Token = "0x4035581")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_ZoomView;

		// Token: 0x04035582 RID: 218498
		[Token(Token = "0x4035582")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_ChangeOpMode;

		// Token: 0x04035583 RID: 218499
		[Token(Token = "0x4035583")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_FocusOnPos;

		// Token: 0x04035584 RID: 218500
		[Token(Token = "0x4035584")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SetBgRaycast;

		// Token: 0x04035585 RID: 218501
		[Token(Token = "0x4035585")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_SetLogoRaycast;

		// Token: 0x04035586 RID: 218502
		[Token(Token = "0x4035586")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_SetCardRaycast;

		// Token: 0x04035587 RID: 218503
		[Token(Token = "0x4035587")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_SetViewportRaycast;

		// Token: 0x04035588 RID: 218504
		[Token(Token = "0x4035588")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_SetAllCardVisible;

		// Token: 0x04035589 RID: 218505
		[Token(Token = "0x4035589")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_SetAllForceLineVisible;

		// Token: 0x0403558A RID: 218506
		[Token(Token = "0x403558A")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_SetAllPointLineVisible;

		// Token: 0x0403558B RID: 218507
		[Token(Token = "0x403558B")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_SaveBgModified;

		// Token: 0x0403558C RID: 218508
		[Token(Token = "0x403558C")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_SaveLogoModified;

		// Token: 0x0403558D RID: 218509
		[Token(Token = "0x403558D")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_SaveColorModified;

		// Token: 0x0403558E RID: 218510
		[Token(Token = "0x403558E")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_SaveCardModified;

		// Token: 0x0403558F RID: 218511
		[Token(Token = "0x403558F")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_SaveForceShapeModified;

		// Token: 0x04035590 RID: 218512
		[Token(Token = "0x4035590")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_AddForceLine;

		// Token: 0x04035591 RID: 218513
		[Token(Token = "0x4035591")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_RemoveForceLine;

		// Token: 0x04035592 RID: 218514
		[Token(Token = "0x4035592")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_AddPointLine;

		// Token: 0x04035593 RID: 218515
		[Token(Token = "0x4035593")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_RemovePointLine;

		// Token: 0x04035594 RID: 218516
		[Token(Token = "0x4035594")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_RemoveForce;

		// Token: 0x04035595 RID: 218517
		[Token(Token = "0x4035595")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_AddNewForce;

		// Token: 0x04035596 RID: 218518
		[Token(Token = "0x4035596")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetClickPos;

		// Token: 0x04035597 RID: 218519
		[Token(Token = "0x4035597")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04035598 RID: 218520
		[Token(Token = "0x4035598")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006744 RID: 26436
		[Token(Token = "0x2006744")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170059CF RID: 22991
			// (get) Token: 0x06025F04 RID: 155396 RVA: 0x000C97E0 File Offset: 0x000C79E0
			// (set) Token: 0x06025F05 RID: 155397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170059CF")]
			public int selectLineIndex
			{
				[Token(Token = "0x6025F04")]
				[Address(RVA = "0x20EE8F0", Offset = "0x20ED4F0", VA = "0x1820EE8F0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6025F05")]
				[Address(RVA = "0x20EE9D0", Offset = "0x20ED5D0", VA = "0x1820EE9D0")]
				set
				{
				}
			}

			// Token: 0x170059D0 RID: 22992
			// (get) Token: 0x06025F06 RID: 155398 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06025F07 RID: 155399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170059D0")]
			public Action<int> onItemSelected
			{
				[Token(Token = "0x6025F06")]
				[Address(RVA = "0x20EE890", Offset = "0x20ED490", VA = "0x1820EE890")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6025F07")]
				[Address(RVA = "0x20EE950", Offset = "0x20ED550", VA = "0x1820EE950")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06025F08 RID: 155400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F08")]
			[Address(RVA = "0x20EE2B0", Offset = "0x20ECEB0", VA = "0x1820EE2B0")]
			public void SetDataSource(List<string> dataSource)
			{
			}

			// Token: 0x170059D1 RID: 22993
			// (get) Token: 0x06025F09 RID: 155401 RVA: 0x000C97F8 File Offset: 0x000C79F8
			[Token(Token = "0x170059D1")]
			public override int count
			{
				[Token(Token = "0x6025F09")]
				[Address(RVA = "0x20EE820", Offset = "0x20ED420", VA = "0x1820EE820", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025F0A RID: 155402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F0A")]
			[Address(RVA = "0x20EDD50", Offset = "0x20EC950", VA = "0x1820EDD50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025F0B RID: 155403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F0B")]
			[Address(RVA = "0x20EE4B0", Offset = "0x20ED0B0", VA = "0x1820EE4B0")]
			private void _OnItemClick(int index)
			{
			}

			// Token: 0x06025F0C RID: 155404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F0C")]
			[Address(RVA = "0x20EE330", Offset = "0x20ECF30", VA = "0x1820EE330")]
			public void SetSelect(int index, bool isSelected)
			{
			}

			// Token: 0x06025F0D RID: 155405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F0D")]
			[Address(RVA = "0x20EDAE0", Offset = "0x20EC6E0", VA = "0x1820EDAE0")]
			public void ClearSelect()
			{
			}

			// Token: 0x06025F0E RID: 155406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F0E")]
			[Address(RVA = "0x20EE410", Offset = "0x20ED010", VA = "0x1820EE410")]
			private HandBookV2EditorLineListItemView _GetItemView(int index)
			{
				return null;
			}

			// Token: 0x06025F0F RID: 155407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F0F")]
			[Address(RVA = "0x20EE5B0", Offset = "0x20ED1B0", VA = "0x1820EE5B0")]
			public Adapter()
			{
			}

			// Token: 0x04035599 RID: 218521
			[Token(Token = "0x4035599")]
			[FieldOffset(Offset = "0x20")]
			private List<string> m_dataSource;

			// Token: 0x0403559A RID: 218522
			[Token(Token = "0x403559A")]
			[FieldOffset(Offset = "0x28")]
			private int m_selectIdx;

			// Token: 0x0403559C RID: 218524
			[Token(Token = "0x403559C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_selectLineIndex;

			// Token: 0x0403559D RID: 218525
			[Token(Token = "0x403559D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_selectLineIndex;

			// Token: 0x0403559E RID: 218526
			[Token(Token = "0x403559E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onItemSelected;

			// Token: 0x0403559F RID: 218527
			[Token(Token = "0x403559F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onItemSelected;

			// Token: 0x040355A0 RID: 218528
			[Token(Token = "0x40355A0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetDataSource;

			// Token: 0x040355A1 RID: 218529
			[Token(Token = "0x40355A1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040355A2 RID: 218530
			[Token(Token = "0x40355A2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040355A3 RID: 218531
			[Token(Token = "0x40355A3")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__OnItemClick;

			// Token: 0x040355A4 RID: 218532
			[Token(Token = "0x40355A4")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SetSelect;

			// Token: 0x040355A5 RID: 218533
			[Token(Token = "0x40355A5")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_ClearSelect;

			// Token: 0x040355A6 RID: 218534
			[Token(Token = "0x40355A6")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__GetItemView;

			// Token: 0x040355A7 RID: 218535
			[Token(Token = "0x40355A7")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
