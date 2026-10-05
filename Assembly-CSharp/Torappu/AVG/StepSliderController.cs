using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F8F RID: 8079
	[Token(Token = "0x2001F8F")]
	public class StepSliderController : MonoBehaviour
	{
		// Token: 0x0600C8C7 RID: 51399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C7")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		public void RegisterOnValueSet(Action<float> onValueSet)
		{
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C8")]
		[Address(RVA = "0x34995F0", Offset = "0x34981F0", VA = "0x1834995F0")]
		private void Start()
		{
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C9")]
		[Address(RVA = "0x3498F60", Offset = "0x3497B60", VA = "0x183498F60")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CA")]
		[Address(RVA = "0x3498F50", Offset = "0x3497B50", VA = "0x183498F50")]
		public void OnBeginDrag()
		{
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CB")]
		[Address(RVA = "0x3499160", Offset = "0x3497D60", VA = "0x183499160")]
		public void OnEndDrag()
		{
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CC")]
		[Address(RVA = "0x34992E0", Offset = "0x3497EE0", VA = "0x1834992E0")]
		private void OnStepButtonClick(int index)
		{
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CD")]
		[Address(RVA = "0x34991D0", Offset = "0x3497DD0", VA = "0x1834991D0")]
		private void OnSliderValueChanged(float val)
		{
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CE")]
		[Address(RVA = "0x34994A0", Offset = "0x34980A0", VA = "0x1834994A0")]
		private void SnapToNearestStep()
		{
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CF")]
		[Address(RVA = "0x31E4FD0", Offset = "0x31E3BD0", VA = "0x1831E4FD0")]
		private void _EventOnValueSet(float floatVal)
		{
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D0")]
		[Address(RVA = "0x34993F0", Offset = "0x3497FF0", VA = "0x1834993F0")]
		public void SetValue(float value)
		{
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D1")]
		[Address(RVA = "0x34999F0", Offset = "0x34985F0", VA = "0x1834999F0")]
		private void _UpdateValueText(float value)
		{
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D2")]
		[Address(RVA = "0x3499B90", Offset = "0x3498790", VA = "0x183499B90")]
		public StepSliderController()
		{
		}

		// Token: 0x0400CF5B RID: 53083
		[Token(Token = "0x400CF5B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandleDragListener _handleDrag;

		// Token: 0x0400CF5C RID: 53084
		[Token(Token = "0x400CF5C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider slider;

		// Token: 0x0400CF5D RID: 53085
		[Token(Token = "0x400CF5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button[] stepButtons;

		// Token: 0x0400CF5E RID: 53086
		[Token(Token = "0x400CF5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float[] stepValues;

		// Token: 0x0400CF5F RID: 53087
		[Token(Token = "0x400CF5F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _valueText;

		// Token: 0x0400CF60 RID: 53088
		[Token(Token = "0x400CF60")]
		[FieldOffset(Offset = "0x40")]
		private float m_snapThreshold;

		// Token: 0x0400CF61 RID: 53089
		[Token(Token = "0x400CF61")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isUserDragging;

		// Token: 0x0400CF62 RID: 53090
		[Token(Token = "0x400CF62")]
		[FieldOffset(Offset = "0x48")]
		private Action<float> m_onValueSet;

		// Token: 0x0400CF63 RID: 53091
		[Token(Token = "0x400CF63")]
		[FieldOffset(Offset = "0x50")]
		private float m_lastValue;
	}
}
