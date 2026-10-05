using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E3 RID: 26339
	[Token(Token = "0x20066E3")]
	public class HandBookGroupDetailEdit : MonoBehaviour
	{
		// Token: 0x06025CB4 RID: 154804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB4")]
		[Address(RVA = "0x20BBD00", Offset = "0x20BA900", VA = "0x1820BBD00")]
		private void init()
		{
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x06025CB5 RID: 154805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005990")]
		public HandBookV2GroupPosData cacheData
		{
			[Token(Token = "0x6025CB5")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025CB6 RID: 154806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB6")]
		[Address(RVA = "0x20BAD30", Offset = "0x20B9930", VA = "0x1820BAD30")]
		public void RenderForce()
		{
		}

		// Token: 0x06025CB7 RID: 154807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB7")]
		[Address(RVA = "0x20BB010", Offset = "0x20B9C10", VA = "0x1820BB010")]
		public void RenderLine()
		{
		}

		// Token: 0x06025CB8 RID: 154808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB8")]
		[Address(RVA = "0x20BB210", Offset = "0x20B9E10", VA = "0x1820BB210")]
		public void Render(HandBookV2GroupPosData posData)
		{
		}

		// Token: 0x06025CB9 RID: 154809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB9")]
		[Address(RVA = "0x20BB990", Offset = "0x20BA590", VA = "0x1820BB990")]
		private void _CheckCard(HandBookGroupCommonPosEdit card, out int x, out int y)
		{
		}

		// Token: 0x06025CBA RID: 154810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CBA")]
		[Address(RVA = "0x20BA890", Offset = "0x20B9490", VA = "0x1820BA890")]
		public void RemovePos(HandBookGroupCommonPosEdit card)
		{
		}

		// Token: 0x06025CBB RID: 154811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CBB")]
		[Address(RVA = "0x20B9690", Offset = "0x20B8290", VA = "0x1820B9690")]
		public void CheckPos(HandBookGroupCommonPosEdit card)
		{
		}

		// Token: 0x06025CBC RID: 154812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CBC")]
		[Address(RVA = "0x20BA170", Offset = "0x20B8D70", VA = "0x1820BA170")]
		public void InstNewForce()
		{
		}

		// Token: 0x06025CBD RID: 154813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CBD")]
		[Address(RVA = "0x20BA370", Offset = "0x20B8F70", VA = "0x1820BA370")]
		public void InstantiateNewChar()
		{
		}

		// Token: 0x06025CBE RID: 154814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CBE")]
		[Address(RVA = "0x20B9A50", Offset = "0x20B8650", VA = "0x1820B9A50")]
		public void DeleteSelectChar()
		{
		}

		// Token: 0x06025CBF RID: 154815 RVA: 0x000C9168 File Offset: 0x000C7368
		[Token(Token = "0x6025CBF")]
		[Address(RVA = "0x20BA020", Offset = "0x20B8C20", VA = "0x1820BA020")]
		public static Vector2 GetConnectHexagonDirectionPos(HexagonDirection direction)
		{
			return default(Vector2);
		}

		// Token: 0x06025CC0 RID: 154816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC0")]
		[Address(RVA = "0x20B9310", Offset = "0x20B7F10", VA = "0x1820B9310")]
		public void CheckPosConnection(int x, int y, List<HandBookV2GroupPosData.Connection> connectionList)
		{
		}

		// Token: 0x06025CC1 RID: 154817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC1")]
		[Address(RVA = "0x20B8F30", Offset = "0x20B7B30", VA = "0x1820B8F30")]
		public void CheckConnection()
		{
		}

		// Token: 0x06025CC2 RID: 154818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC2")]
		[Address(RVA = "0x20BA980", Offset = "0x20B9580", VA = "0x1820BA980")]
		public void RenderForceColor()
		{
		}

		// Token: 0x06025CC3 RID: 154819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC3")]
		[Address(RVA = "0x20B9F00", Offset = "0x20B8B00", VA = "0x1820B9F00")]
		public void FocusForce(string forceId)
		{
		}

		// Token: 0x06025CC4 RID: 154820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC4")]
		[Address(RVA = "0x20BB4E0", Offset = "0x20BA0E0", VA = "0x1820BB4E0")]
		public void SaveFocusForce(string forceId)
		{
		}

		// Token: 0x06025CC5 RID: 154821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC5")]
		[Address(RVA = "0x20B87D0", Offset = "0x20B73D0", VA = "0x1820B87D0")]
		public void AddForceColorBar(string forceId)
		{
		}

		// Token: 0x06025CC6 RID: 154822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC6")]
		[Address(RVA = "0x20B9950", Offset = "0x20B8550", VA = "0x1820B9950")]
		public void DeleteForce(string forceId)
		{
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC7")]
		[Address(RVA = "0x20BB600", Offset = "0x20BA200", VA = "0x1820BB600")]
		public void SetForce(string forceId)
		{
		}

		// Token: 0x06025CC8 RID: 154824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC8")]
		[Address(RVA = "0x20BA530", Offset = "0x20B9130", VA = "0x1820BA530")]
		public void LargeSize()
		{
		}

		// Token: 0x06025CC9 RID: 154825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CC9")]
		[Address(RVA = "0x20BB870", Offset = "0x20BA470", VA = "0x1820BB870")]
		public void SmallSize()
		{
		}

		// Token: 0x06025CCA RID: 154826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CCA")]
		[Address(RVA = "0x20BA650", Offset = "0x20B9250", VA = "0x1820BA650")]
		public void NormalSize()
		{
		}

		// Token: 0x06025CCB RID: 154827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CCB")]
		[Address(RVA = "0x20BA750", Offset = "0x20B9350", VA = "0x1820BA750")]
		public void RemoveLine()
		{
		}

		// Token: 0x06025CCC RID: 154828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CCC")]
		[Address(RVA = "0x20B8BD0", Offset = "0x20B77D0", VA = "0x1820B8BD0")]
		public void AddLine()
		{
		}

		// Token: 0x06025CCD RID: 154829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CCD")]
		[Address(RVA = "0x20BBAF0", Offset = "0x20BA6F0", VA = "0x1820BBAF0")]
		public HandBookGroupDetailEdit()
		{
		}

		// Token: 0x04035236 RID: 217654
		[Token(Token = "0x4035236")]
		[FieldOffset(Offset = "0x0")]
		public static HandBookGroupDetailEdit instance;

		// Token: 0x04035237 RID: 217655
		[Token(Token = "0x4035237")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookGroupCharEdit _edit;

		// Token: 0x04035238 RID: 217656
		[Token(Token = "0x4035238")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookForceLogoEdit _logoEdit;

		// Token: 0x04035239 RID: 217657
		[Token(Token = "0x4035239")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandBookV2ColorBlockEdit _colorEdit;

		// Token: 0x0403523A RID: 217658
		[Token(Token = "0x403523A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403523B RID: 217659
		[Token(Token = "0x403523B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField _charNameInputField;

		// Token: 0x0403523C RID: 217660
		[Token(Token = "0x403523C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField _forceIdInputField;

		// Token: 0x0403523D RID: 217661
		[Token(Token = "0x403523D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HandBookV2MapLineView _lineView;

		// Token: 0x0403523E RID: 217662
		[Token(Token = "0x403523E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _lineContainer;

		// Token: 0x0403523F RID: 217663
		[Token(Token = "0x403523F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _forceContent;

		// Token: 0x04035240 RID: 217664
		[Token(Token = "0x4035240")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent _onClick;

		// Token: 0x04035241 RID: 217665
		[Token(Token = "0x4035241")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _onFocusView;

		// Token: 0x04035242 RID: 217666
		[Token(Token = "0x4035242")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onSaveFocusView;

		// Token: 0x04035243 RID: 217667
		[Token(Token = "0x4035243")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStringEvent _onDeleteForce;

		// Token: 0x04035244 RID: 217668
		[Token(Token = "0x4035244")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _scrollContainer;

		// Token: 0x04035245 RID: 217669
		[Token(Token = "0x4035245")]
		[FieldOffset(Offset = "0x88")]
		private HandBookGroupForceEditAdapter m_adapter;

		// Token: 0x04035246 RID: 217670
		[Token(Token = "0x4035246")]
		[FieldOffset(Offset = "0x90")]
		public float _lineLength;

		// Token: 0x04035247 RID: 217671
		[Token(Token = "0x4035247")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Dictionary<string, HandBookGroupCharEdit> charList;

		// Token: 0x04035248 RID: 217672
		[Token(Token = "0x4035248")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Dictionary<string, HandBookV2ColorBlockEdit> colorBarList;

		// Token: 0x04035249 RID: 217673
		[Token(Token = "0x4035249")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Dictionary<string, HandBookForceLogoEdit> forceLogoList;

		// Token: 0x0403524A RID: 217674
		[Token(Token = "0x403524A")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public List<string> onSelectChar;

		// Token: 0x0403524B RID: 217675
		[Token(Token = "0x403524B")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public Dictionary<KeyValuePair<int, int>, HandBookGroupCommonPosEdit> charMap;

		// Token: 0x0403524C RID: 217676
		[Token(Token = "0x403524C")]
		[FieldOffset(Offset = "0xC0")]
		private HandBookV2GroupPosData m_cacheData;

		// Token: 0x0403524D RID: 217677
		[Token(Token = "0x403524D")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public int lineMaxInt;
	}
}
