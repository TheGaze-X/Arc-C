using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[RequireComponent(typeof(RectTransform))]
	public class TextContainer : UIBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public bool hasChanged
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public Vector2 pivot
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x20BDE00", Offset = "0x20BCA00", VA = "0x1820BDE00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x586DD80", Offset = "0x586C980", VA = "0x18586DD80")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public TextContainerAnchors anchorPosition
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return TextContainerAnchors.TopLeft;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x586DB80", Offset = "0x586C780", VA = "0x18586DB80")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public Rect rect
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x586DE00", Offset = "0x586CA00", VA = "0x18586DE00")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public Vector2 size
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x586DA90", Offset = "0x586C690", VA = "0x18586DA90")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x586DE60", Offset = "0x586CA60", VA = "0x18586DE60")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public float width
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x586DB70", Offset = "0x586C770", VA = "0x18586DB70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x586DF00", Offset = "0x586CB00", VA = "0x18586DF00")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public float height
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x586D9E0", Offset = "0x586C5E0", VA = "0x18586D9E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x586DCB0", Offset = "0x586C8B0", VA = "0x18586DCB0")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x17000009")]
		public bool isDefaultWidth
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x1700000A")]
		public bool isDefaultHeight
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool isAutoFitting
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1694F60", Offset = "0x1693B60", VA = "0x181694F60")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000C")]
		public Vector3[] corners
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000D")]
		public Vector3[] worldCorners
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public Vector4 margins
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x157CF50", Offset = "0x157BB50", VA = "0x18157CF50")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x586DD00", Offset = "0x586C900", VA = "0x18586DD00")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x586D9F0", Offset = "0x586C5F0", VA = "0x18586D9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000010")]
		public TextMeshPro textMeshPro
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x586DAD0", Offset = "0x586C6D0", VA = "0x18586DAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x586CD30", Offset = "0x586B930", VA = "0x18586CD30", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x586D320", Offset = "0x586BF20", VA = "0x18586D320", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x586D140", Offset = "0x586BD40", VA = "0x18586D140")]
		private void OnContainerChanged()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x586D330", Offset = "0x586BF30", VA = "0x18586D330", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x586D5F0", Offset = "0x586C1F0", VA = "0x18586D5F0")]
		private void SetRect(Vector2 size)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x586D670", Offset = "0x586C270", VA = "0x18586D670")]
		private void UpdateCorners()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x586D000", Offset = "0x586BC00", VA = "0x18586D000")]
		private Vector2 GetPivot(TextContainerAnchors anchor)
		{
			return default(Vector2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x586CDE0", Offset = "0x586B9E0", VA = "0x18586CDE0")]
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			return TextContainerAnchors.TopLeft;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x586D960", Offset = "0x586C560", VA = "0x18586D960")]
		public TextContainer()
		{
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		private bool m_hasChanged;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 m_pivot;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextContainerAnchors m_anchorPosition;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rect m_rect;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isDefaultWidth;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isDefaultHeight;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_isAutoFitting;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x40")]
		private Vector3[] m_corners;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] m_worldCorners;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector4 m_margins;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x60")]
		private RectTransform m_rectTransform;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 k_defaultSize;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x68")]
		private TextMeshPro m_textMeshPro;
	}
}
