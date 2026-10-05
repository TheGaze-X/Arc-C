using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003793 RID: 14227
	[Token(Token = "0x2003793")]
	public class EasyInstancePool : MonoBehaviour
	{
		// Token: 0x1700360A RID: 13834
		[Token(Token = "0x1700360A")]
		public GameObject this[int i]
		{
			[Token(Token = "0x6016929")]
			[Address(RVA = "0xEF7E70", Offset = "0xEF6A70", VA = "0x180EF7E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0601692A RID: 92458 RVA: 0x00091E30 File Offset: 0x00090030
		[Token(Token = "0x1700360B")]
		public int count
		{
			[Token(Token = "0x601692A")]
			[Address(RVA = "0xEF8010", Offset = "0xEF6C10", VA = "0x180EF8010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0601692B RID: 92459 RVA: 0x00091E48 File Offset: 0x00090048
		[Token(Token = "0x1700360C")]
		public Vector2 size
		{
			[Token(Token = "0x601692B")]
			[Address(RVA = "0xEF8050", Offset = "0xEF6C50", VA = "0x180EF8050")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0601692C RID: 92460 RVA: 0x00091E60 File Offset: 0x00090060
		[Token(Token = "0x1700360D")]
		public Vector2 center
		{
			[Token(Token = "0x601692C")]
			[Address(RVA = "0xEF7F10", Offset = "0xEF6B10", VA = "0x180EF7F10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0601692D RID: 92461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601692D")]
		[Address(RVA = "0xEF72E0", Offset = "0xEF5EE0", VA = "0x180EF72E0")]
		public void MakeItems(int count)
		{
		}

		// Token: 0x0601692E RID: 92462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601692E")]
		[Address(RVA = "0xEF70D0", Offset = "0xEF5CD0", VA = "0x180EF70D0")]
		public GameObject AllocateObject(bool setActive = true)
		{
			return null;
		}

		// Token: 0x0601692F RID: 92463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601692F")]
		[Address(RVA = "0xEF75C0", Offset = "0xEF61C0", VA = "0x180EF75C0")]
		public void RecycleObject(GameObject obj, bool setInActive = true)
		{
		}

		// Token: 0x06016930 RID: 92464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016930")]
		[Address(RVA = "0xEF71E0", Offset = "0xEF5DE0", VA = "0x180EF71E0")]
		public void DestroyInstancesInUseList()
		{
		}

		// Token: 0x06016931 RID: 92465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016931")]
		[Address(RVA = "0xEF7770", Offset = "0xEF6370", VA = "0x180EF7770")]
		private void _CreateInstance()
		{
		}

		// Token: 0x06016932 RID: 92466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016932")]
		[Address(RVA = "0xEF7A70", Offset = "0xEF6670", VA = "0x180EF7A70")]
		private void _SetPos()
		{
		}

		// Token: 0x06016933 RID: 92467 RVA: 0x00091E78 File Offset: 0x00090078
		[Token(Token = "0x6016933")]
		[Address(RVA = "0xEF79D0", Offset = "0xEF65D0", VA = "0x180EF79D0")]
		private Vector3 _GetOffsetPos(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06016934 RID: 92468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016934")]
		[Address(RVA = "0xEF76C0", Offset = "0xEF62C0", VA = "0x180EF76C0")]
		private void _CalcRowCol()
		{
		}

		// Token: 0x06016935 RID: 92469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016935")]
		[Address(RVA = "0xEF76B0", Offset = "0xEF62B0", VA = "0x180EF76B0")]
		private void Start()
		{
		}

		// Token: 0x06016936 RID: 92470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016936")]
		[Address(RVA = "0xEF75A0", Offset = "0xEF61A0", VA = "0x180EF75A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06016937 RID: 92471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016937")]
		[Address(RVA = "0xEF7DB0", Offset = "0xEF69B0", VA = "0x180EF7DB0")]
		public EasyInstancePool()
		{
		}

		// Token: 0x0401B344 RID: 111428
		[Token(Token = "0x401B344")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _testItemsCnt;

		// Token: 0x0401B345 RID: 111429
		[Token(Token = "0x401B345")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEngine.Object _instancePrefab;

		// Token: 0x0401B346 RID: 111430
		[Token(Token = "0x401B346")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoFillIndex;

		// Token: 0x0401B347 RID: 111431
		[Token(Token = "0x401B347")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _autoAdjustPos;

		// Token: 0x0401B348 RID: 111432
		[Token(Token = "0x401B348")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _setZAxisToZero;

		// Token: 0x0401B349 RID: 111433
		[Token(Token = "0x401B349")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _clearOnDisable;

		// Token: 0x0401B34A RID: 111434
		[Token(Token = "0x401B34A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _slotsBeginPos;

		// Token: 0x0401B34B RID: 111435
		[Token(Token = "0x401B34B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _slotsOffsetPos;

		// Token: 0x0401B34C RID: 111436
		[Token(Token = "0x401B34C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _slotsMaxPerLineOrRow;

		// Token: 0x0401B34D RID: 111437
		[Token(Token = "0x401B34D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _horizontal;

		// Token: 0x0401B34E RID: 111438
		[Token(Token = "0x401B34E")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public EasyInstancePool.OnItemChangeUsage onItemDequeue;

		// Token: 0x0401B34F RID: 111439
		[Token(Token = "0x401B34F")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public EasyInstancePool.OnItemChangeUsage onItemEnqueue;

		// Token: 0x0401B350 RID: 111440
		[Token(Token = "0x401B350")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public EasyInstancePool.MessageCb onMakeItemsComplete;

		// Token: 0x0401B351 RID: 111441
		[Token(Token = "0x401B351")]
		[FieldOffset(Offset = "0x60")]
		private int m_rowNum;

		// Token: 0x0401B352 RID: 111442
		[Token(Token = "0x401B352")]
		[FieldOffset(Offset = "0x64")]
		private int m_colNum;

		// Token: 0x0401B353 RID: 111443
		[Token(Token = "0x401B353")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_instancesInUse;

		// Token: 0x0401B354 RID: 111444
		[Token(Token = "0x401B354")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> m_instancesNotInUse;

		// Token: 0x02003794 RID: 14228
		// (Invoke) Token: 0x06016939 RID: 92473
		[Token(Token = "0x2003794")]
		public delegate void MessageCb();

		// Token: 0x02003795 RID: 14229
		// (Invoke) Token: 0x0601693D RID: 92477
		[Token(Token = "0x2003795")]
		public delegate void OnItemChangeUsage(GameObject obj);
	}
}
