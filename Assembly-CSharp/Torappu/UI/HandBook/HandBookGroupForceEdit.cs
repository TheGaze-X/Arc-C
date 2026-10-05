using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E5 RID: 26341
	[Token(Token = "0x20066E5")]
	public class HandBookGroupForceEdit : MonoBehaviour
	{
		// Token: 0x06025CD4 RID: 154836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD4")]
		[Address(RVA = "0x20BCC30", Offset = "0x20BB830", VA = "0x1820BCC30")]
		public void Render(HandBookV2GroupPosData.ForceData forceData)
		{
		}

		// Token: 0x06025CD5 RID: 154837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD5")]
		[Address(RVA = "0x20BC750", Offset = "0x20BB350", VA = "0x1820BC750")]
		public void OnColorEdit(string color)
		{
		}

		// Token: 0x06025CD6 RID: 154838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD6")]
		[Address(RVA = "0x20BC6F0", Offset = "0x20BB2F0", VA = "0x1820BC6F0")]
		public void OnClick()
		{
		}

		// Token: 0x06025CD7 RID: 154839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD7")]
		[Address(RVA = "0x20BC7D0", Offset = "0x20BB3D0", VA = "0x1820BC7D0")]
		public void OnDelete()
		{
		}

		// Token: 0x06025CD8 RID: 154840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD8")]
		[Address(RVA = "0x20BC920", Offset = "0x20BB520", VA = "0x1820BC920")]
		public void OnFocus()
		{
		}

		// Token: 0x06025CD9 RID: 154841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD9")]
		[Address(RVA = "0x20BCA80", Offset = "0x20BB680", VA = "0x1820BCA80")]
		public void OnSaveFocus()
		{
		}

		// Token: 0x06025CDA RID: 154842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CDA")]
		[Address(RVA = "0x20BC690", Offset = "0x20BB290", VA = "0x1820BC690")]
		public void OnAddColor()
		{
		}

		// Token: 0x06025CDB RID: 154843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CDB")]
		[Address(RVA = "0x20BCBE0", Offset = "0x20BB7E0", VA = "0x1820BCBE0")]
		public void OnToggleClick()
		{
		}

		// Token: 0x06025CDC RID: 154844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CDC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookGroupForceEdit()
		{
		}

		// Token: 0x04035254 RID: 217684
		[Token(Token = "0x4035254")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _colorStr;

		// Token: 0x04035255 RID: 217685
		[Token(Token = "0x4035255")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _forceId;

		// Token: 0x04035256 RID: 217686
		[Token(Token = "0x4035256")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _forceColor;

		// Token: 0x04035257 RID: 217687
		[Token(Token = "0x4035257")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _isThisGroupToggle;

		// Token: 0x04035258 RID: 217688
		[Token(Token = "0x4035258")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent onClick;

		// Token: 0x04035259 RID: 217689
		[Token(Token = "0x4035259")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public UIStringEvent onFocusView;

		// Token: 0x0403525A RID: 217690
		[Token(Token = "0x403525A")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringEvent onSaveFocusView;

		// Token: 0x0403525B RID: 217691
		[Token(Token = "0x403525B")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIStringEvent onDeleteFocusView;

		// Token: 0x0403525C RID: 217692
		[Token(Token = "0x403525C")]
		[FieldOffset(Offset = "0x58")]
		private HandBookV2GroupPosData.ForceData m_cacheForceData;
	}
}
