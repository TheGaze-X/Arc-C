using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.CETest
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class CETestControl : MonoBehaviour
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x54D83D0", Offset = "0x54D6FD0", VA = "0x1854D83D0")]
		private static void _UpdateUIByData(CETestControl me, CETestDataType data, Transform transformContent, GameObject selectButtonLevelPrefab)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x54D6140", Offset = "0x54D4D40", VA = "0x1854D6140")]
		private void Start()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x54D76E0", Offset = "0x54D62E0", VA = "0x1854D76E0")]
		private IEnumerator _NevigateCoroutine(RectTransform[] parameters)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x54D5630", Offset = "0x54D4230", VA = "0x1854D5630")]
		public void OnLevelSelected(string id, CETestDataLevel data)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x54D7770", Offset = "0x54D6370", VA = "0x1854D7770")]
		private void _Nevigate(RectTransform levelTransform, RectTransform squadTransform)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x54D7870", Offset = "0x54D6470", VA = "0x1854D7870")]
		private void _SetRectTransformByAligningExistingTransform(ScrollRect rectToMove, RectTransform rectReference, RectTransform viewport, RectTransform content)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x54D72B0", Offset = "0x54D5EB0", VA = "0x1854D72B0")]
		private Vector3 _ConvertLocalPosToWorldPos(RectTransform target)
		{
			return default(Vector3);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x54D7B80", Offset = "0x54D6780", VA = "0x1854D7B80")]
		private static void _UpdateSquadUI(CETestControl me, string levelId, CETestDataType data, Transform transformContent, GameObject selectButtonSquadPrefab)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x54D5B40", Offset = "0x54D4740", VA = "0x1854D5B40")]
		public void OnSquadSelected(string id, CETestDataSquad data)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x54D7430", Offset = "0x54D6030", VA = "0x1854D7430")]
		private Color _GetLevelButtonColor(string levelId)
		{
			return default(Color);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x54D7640", Offset = "0x54D6240", VA = "0x1854D7640")]
		private Color _GetSquadButtonColor(string levelId, string squadId)
		{
			return default(Color);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x54D8A10", Offset = "0x54D7610", VA = "0x1854D8A10")]
		public CETestControl()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		private Color SelectColor;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		private Color NotSelectColor;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x38")]
		private Color TestedColor;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		private Color PartialTestedColor;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _selectButtonLevelPrefab;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _selectButtonSquadPrefab;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _buttonStart;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _buttonLogin;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _scrollRectLevels;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollRect _scrollRectSquads;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _viewportLevels;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _viewportSquads;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _transformLevelsContent;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _transformSquadsContent;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textLevelName;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _textLevelDescription;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textSquadName;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textSquadDescription;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xC8")]
		private ICETestBridge m_bridge;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xD0")]
		private CETestDataType m_data;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xD8")]
		private CESelectButtonLevelControl m_selectedLevelControl;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xE0")]
		private CESelectButtonSquadControl m_selectedSquadControl;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xE8")]
		private RectTransform m_contentLevels;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xF0")]
		private RectTransform m_contentSquads;
	}
}
