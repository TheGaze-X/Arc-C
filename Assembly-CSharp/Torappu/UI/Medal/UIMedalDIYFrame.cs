using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004926 RID: 18726
	[Token(Token = "0x2004926")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class UIMedalDIYFrame : MonoBehaviour, IHotfixable, IOnPrefabUpdated
	{
		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x0601C3B5 RID: 115637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042F6")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x601C3B5")]
			[Address(RVA = "0x15BB160", Offset = "0x15B9D60", VA = "0x1815BB160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x0601C3B6 RID: 115638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042F7")]
		public string frameId
		{
			[Token(Token = "0x601C3B6")]
			[Address(RVA = "0x15BB100", Offset = "0x15B9D00", VA = "0x1815BB100")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C3B7 RID: 115639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3B7")]
		[Address(RVA = "0x15BA8C0", Offset = "0x15B94C0", VA = "0x1815BA8C0")]
		public void Init(UIPage page, bool usePool = false)
		{
		}

		// Token: 0x0601C3B8 RID: 115640 RVA: 0x000A79D0 File Offset: 0x000A5BD0
		[Token(Token = "0x601C3B8")]
		[Address(RVA = "0x15BA580", Offset = "0x15B9180", VA = "0x1815BA580")]
		public HexPoint AlignToHex(RectTransform child)
		{
			return default(HexPoint);
		}

		// Token: 0x0601C3B9 RID: 115641 RVA: 0x000A79E8 File Offset: 0x000A5BE8
		[Token(Token = "0x601C3B9")]
		[Address(RVA = "0x15BA720", Offset = "0x15B9320", VA = "0x1815BA720")]
		public Vector2 ConvertToAnchoredPos(HexPoint point)
		{
			return default(Vector2);
		}

		// Token: 0x0601C3BA RID: 115642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C3BA")]
		[Address(RVA = "0x15BA800", Offset = "0x15B9400", VA = "0x1815BA800")]
		public List<HexPoint> GetBound()
		{
			return null;
		}

		// Token: 0x0601C3BB RID: 115643 RVA: 0x000A7A00 File Offset: 0x000A5C00
		[Token(Token = "0x601C3BB")]
		[Address(RVA = "0x15BA860", Offset = "0x15B9460", VA = "0x1815BA860")]
		public float GetUnit()
		{
			return 0f;
		}

		// Token: 0x0601C3BC RID: 115644 RVA: 0x000A7A18 File Offset: 0x000A5C18
		[Token(Token = "0x601C3BC")]
		[Address(RVA = "0x15BAAE0", Offset = "0x15B96E0", VA = "0x1815BAAE0")]
		public UIMedalDIYFrame.PosValidateResult ValidateMedalPosition(UIMedalDIYFrame.MedalPosInfo target, List<UIMedalDIYFrame.MedalPosInfo> others)
		{
			return default(UIMedalDIYFrame.PosValidateResult);
		}

		// Token: 0x0601C3BD RID: 115645 RVA: 0x000A7A30 File Offset: 0x000A5C30
		[Token(Token = "0x601C3BD")]
		[Address(RVA = "0x15BAD80", Offset = "0x15B9980", VA = "0x1815BAD80")]
		public bool ValidateMedalPositions(List<UIMedalDIYFrame.MedalPosInfo> medalList)
		{
			return default(bool);
		}

		// Token: 0x0601C3BE RID: 115646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3BE")]
		[Address(RVA = "0x15BA9F0", Offset = "0x15B95F0", VA = "0x1815BA9F0")]
		public void PopulateGraphics(List<Graphic> list)
		{
		}

		// Token: 0x0601C3BF RID: 115647 RVA: 0x000A7A48 File Offset: 0x000A5C48
		[Token(Token = "0x601C3BF")]
		[Address(RVA = "0x15BAED0", Offset = "0x15B9AD0", VA = "0x1815BAED0")]
		private Vector2 _GetCrossPos(RectTransform child)
		{
			return default(Vector2);
		}

		// Token: 0x0601C3C0 RID: 115648 RVA: 0x000A7A60 File Offset: 0x000A5C60
		[Token(Token = "0x601C3C0")]
		[Address(RVA = "0x15BAFB0", Offset = "0x15B9BB0", VA = "0x1815BAFB0")]
		private static int _MedalSizeToUnit(MedalSize size)
		{
			return 0;
		}

		// Token: 0x0601C3C1 RID: 115649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C1")]
		[Address(RVA = "0x15BAA80", Offset = "0x15B9680", VA = "0x1815BAA80", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x0601C3C2 RID: 115650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C2")]
		[Address(RVA = "0x15BA990", Offset = "0x15B9590", VA = "0x1815BA990", Slot = "4")]
		public void OnPrefabUpdated()
		{
		}

		// Token: 0x0601C3C3 RID: 115651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C3")]
		[Address(RVA = "0x15BB040", Offset = "0x15B9C40", VA = "0x1815BB040")]
		public UIMedalDIYFrame()
		{
		}

		// Token: 0x04024EC9 RID: 151241
		[Token(Token = "0x4024EC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<HexPoint> _bound;

		// Token: 0x04024ECA RID: 151242
		[Token(Token = "0x4024ECA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _unit;

		// Token: 0x04024ECB RID: 151243
		[Token(Token = "0x4024ECB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private string _frameId;

		// Token: 0x04024ECC RID: 151244
		[Token(Token = "0x4024ECC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgMesh;

		// Token: 0x04024ECD RID: 151245
		[Token(Token = "0x4024ECD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("A frame is predefined if it is unselectable by players")]
		private bool _isPredefinedFrame;

		// Token: 0x04024ECE RID: 151246
		[Token(Token = "0x4024ECE")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_rectTrans;

		// Token: 0x04024ECF RID: 151247
		[Token(Token = "0x4024ECF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x04024ED0 RID: 151248
		[Token(Token = "0x4024ED0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_frameId;

		// Token: 0x04024ED1 RID: 151249
		[Token(Token = "0x4024ED1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024ED2 RID: 151250
		[Token(Token = "0x4024ED2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AlignToHex;

		// Token: 0x04024ED3 RID: 151251
		[Token(Token = "0x4024ED3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConvertToAnchoredPos;

		// Token: 0x04024ED4 RID: 151252
		[Token(Token = "0x4024ED4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBound;

		// Token: 0x04024ED5 RID: 151253
		[Token(Token = "0x4024ED5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetUnit;

		// Token: 0x04024ED6 RID: 151254
		[Token(Token = "0x4024ED6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ValidateMedalPosition;

		// Token: 0x04024ED7 RID: 151255
		[Token(Token = "0x4024ED7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ValidateMedalPositions;

		// Token: 0x04024ED8 RID: 151256
		[Token(Token = "0x4024ED8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PopulateGraphics;

		// Token: 0x04024ED9 RID: 151257
		[Token(Token = "0x4024ED9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetCrossPos;

		// Token: 0x04024EDA RID: 151258
		[Token(Token = "0x4024EDA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__MedalSizeToUnit;

		// Token: 0x04024EDB RID: 151259
		[Token(Token = "0x4024EDB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04024EDC RID: 151260
		[Token(Token = "0x4024EDC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnPrefabUpdated;

		// Token: 0x04024EDD RID: 151261
		[Token(Token = "0x4024EDD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004927 RID: 18727
		[Token(Token = "0x2004927")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x04024EDE RID: 151262
			[Token(Token = "0x4024EDE")]
			[FieldOffset(Offset = "0x0")]
			public MedalSize size;

			// Token: 0x04024EDF RID: 151263
			[Token(Token = "0x4024EDF")]
			[FieldOffset(Offset = "0x4")]
			public float imgSize;

			// Token: 0x04024EE0 RID: 151264
			[Token(Token = "0x4024EE0")]
			[FieldOffset(Offset = "0x8")]
			public float colliderSize;
		}

		// Token: 0x02004928 RID: 18728
		[Token(Token = "0x2004928")]
		public struct PosValidateResult
		{
			// Token: 0x0601C3C4 RID: 115652 RVA: 0x000A7A78 File Offset: 0x000A5C78
			[Token(Token = "0x601C3C4")]
			[Address(RVA = "0x15B2140", Offset = "0x15B0D40", VA = "0x1815B2140")]
			public bool IsPosValid()
			{
				return default(bool);
			}

			// Token: 0x04024EE1 RID: 151265
			[Token(Token = "0x4024EE1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalDIYFrame.PosValidateResult NONE;

			// Token: 0x04024EE2 RID: 151266
			[Token(Token = "0x4024EE2")]
			[FieldOffset(Offset = "0x0")]
			public bool allInBound;

			// Token: 0x04024EE3 RID: 151267
			[Token(Token = "0x4024EE3")]
			[FieldOffset(Offset = "0x1")]
			public bool allOutBound;

			// Token: 0x04024EE4 RID: 151268
			[Token(Token = "0x4024EE4")]
			[FieldOffset(Offset = "0x2")]
			public bool overlapped;

			// Token: 0x04024EE5 RID: 151269
			[Token(Token = "0x4024EE5")]
			[FieldOffset(Offset = "0x4")]
			public int outOfBoundVertices;
		}

		// Token: 0x02004929 RID: 18729
		[Token(Token = "0x2004929")]
		public struct MedalPosInfo
		{
			// Token: 0x04024EE6 RID: 151270
			[Token(Token = "0x4024EE6")]
			[FieldOffset(Offset = "0x0")]
			public HexPoint pos;

			// Token: 0x04024EE7 RID: 151271
			[Token(Token = "0x4024EE7")]
			[FieldOffset(Offset = "0x8")]
			public MedalSize size;

			// Token: 0x04024EE8 RID: 151272
			[Token(Token = "0x4024EE8")]
			[FieldOffset(Offset = "0x10")]
			public string medalId;
		}
	}
}
