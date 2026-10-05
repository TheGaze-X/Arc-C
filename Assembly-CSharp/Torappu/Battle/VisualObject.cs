using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002629 RID: 9769
	[Token(Token = "0x2002629")]
	public class VisualObject : MonoBehaviour, ILocatable
	{
		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600FFB2 RID: 65458 RVA: 0x000612F0 File Offset: 0x0005F4F0
		[Token(Token = "0x170022E3")]
		public Vector2 mapPosition
		{
			[Token(Token = "0x600FFB2")]
			[Address(RVA = "0x78A280", Offset = "0x788E80", VA = "0x18078A280", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600FFB3 RID: 65459 RVA: 0x00061308 File Offset: 0x0005F508
		[Token(Token = "0x170022E4")]
		public Vector3 mapPositionV3
		{
			[Token(Token = "0x600FFB3")]
			[Address(RVA = "0x78A230", Offset = "0x788E30", VA = "0x18078A230", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600FFB4 RID: 65460 RVA: 0x00061320 File Offset: 0x0005F520
		[Token(Token = "0x170022E5")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x600FFB4")]
			[Address(RVA = "0x78A3B0", Offset = "0x788FB0", VA = "0x18078A3B0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600FFB5 RID: 65461 RVA: 0x00061338 File Offset: 0x0005F538
		[Token(Token = "0x170022E6")]
		public float height
		{
			[Token(Token = "0x600FFB5")]
			[Address(RVA = "0x78A150", Offset = "0x788D50", VA = "0x18078A150", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600FFB6 RID: 65462 RVA: 0x00061350 File Offset: 0x0005F550
		[Token(Token = "0x170022E7")]
		public virtual Vector2 faceTo
		{
			[Token(Token = "0x600FFB6")]
			[Address(RVA = "0x78A080", Offset = "0x788C80", VA = "0x18078A080", Slot = "10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600FFB7 RID: 65463 RVA: 0x00061368 File Offset: 0x0005F568
		[Token(Token = "0x170022E8")]
		public virtual GridPosition gridPosition
		{
			[Token(Token = "0x600FFB7")]
			[Address(RVA = "0x78A0C0", Offset = "0x788CC0", VA = "0x18078A0C0", Slot = "11")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600FFB8 RID: 65464 RVA: 0x00061380 File Offset: 0x0005F580
		[Token(Token = "0x170022E9")]
		public float x
		{
			[Token(Token = "0x600FFB8")]
			[Address(RVA = "0x78A400", Offset = "0x789000", VA = "0x18078A400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600FFB9 RID: 65465 RVA: 0x00061398 File Offset: 0x0005F598
		[Token(Token = "0x170022EA")]
		public float y
		{
			[Token(Token = "0x600FFB9")]
			[Address(RVA = "0x78A430", Offset = "0x789030", VA = "0x18078A430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600FFBA RID: 65466 RVA: 0x000613B0 File Offset: 0x0005F5B0
		[Token(Token = "0x170022EB")]
		public float z
		{
			[Token(Token = "0x600FFBA")]
			[Address(RVA = "0x78A460", Offset = "0x789060", VA = "0x18078A460")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600FFBB RID: 65467 RVA: 0x000613C8 File Offset: 0x0005F5C8
		[Token(Token = "0x170022EC")]
		public int row
		{
			[Token(Token = "0x600FFBB")]
			[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600FFBC RID: 65468 RVA: 0x000613E0 File Offset: 0x0005F5E0
		[Token(Token = "0x170022ED")]
		public int col
		{
			[Token(Token = "0x600FFBC")]
			[Address(RVA = "0x78A040", Offset = "0x788C40", VA = "0x18078A040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600FFBD RID: 65469 RVA: 0x000613F8 File Offset: 0x0005F5F8
		[Token(Token = "0x170022EE")]
		public Rect mapRect
		{
			[Token(Token = "0x600FFBD")]
			[Address(RVA = "0x78A2C0", Offset = "0x788EC0", VA = "0x18078A2C0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600FFBE RID: 65470 RVA: 0x00061410 File Offset: 0x0005F610
		[Token(Token = "0x170022EF")]
		public Bounds mapBounds
		{
			[Token(Token = "0x600FFBE")]
			[Address(RVA = "0x78A190", Offset = "0x788D90", VA = "0x18078A190")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x0600FFBF RID: 65471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFBF")]
		[Address(RVA = "0x789E10", Offset = "0x788A10", VA = "0x180789E10")]
		public void SetPosition(GridPosition gridPosition)
		{
		}

		// Token: 0x0600FFC0 RID: 65472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC0")]
		[Address(RVA = "0x789D70", Offset = "0x788970", VA = "0x180789D70")]
		public void SetPosition(Vector2 pos)
		{
		}

		// Token: 0x0600FFC1 RID: 65473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC1")]
		[Address(RVA = "0x789C90", Offset = "0x788890", VA = "0x180789C90")]
		public void SetPositionV3(Vector3 pos)
		{
		}

		// Token: 0x0600FFC2 RID: 65474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC2")]
		[Address(RVA = "0x789CF0", Offset = "0x7888F0", VA = "0x180789CF0")]
		protected void SetPositionWithHeight(Vector2 pos, float height)
		{
		}

		// Token: 0x0600FFC3 RID: 65475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC3")]
		[Address(RVA = "0x789BF0", Offset = "0x7887F0", VA = "0x180789BF0", Slot = "12")]
		public virtual void SetHeight(float height, bool isInit = false)
		{
		}

		// Token: 0x0600FFC4 RID: 65476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC4")]
		[Address(RVA = "0x789EF0", Offset = "0x788AF0", VA = "0x180789EF0")]
		protected void TruncateCurrentPos()
		{
		}

		// Token: 0x0600FFC5 RID: 65477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC5")]
		[Address(RVA = "0x789F80", Offset = "0x788B80", VA = "0x180789F80", Slot = "13")]
		protected virtual void _AssignLocalPosInternal(Vector3 localPos)
		{
		}

		// Token: 0x0600FFC6 RID: 65478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VisualObject()
		{
		}
	}
}
