using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003991 RID: 14737
	[Token(Token = "0x2003991")]
	public abstract class EditorMeshCanvasDrawer : MonoBehaviour, IMeshCanvasDrawer
	{
		// Token: 0x060174C9 RID: 95433 RVA: 0x00095DA8 File Offset: 0x00093FA8
		[Token(Token = "0x60174C9")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
		public int GetLayer()
		{
			return 0;
		}

		// Token: 0x060174CA RID: 95434
		[Token(Token = "0x60174CA")]
		public abstract void PopulateOperations(EditorMeshCanvas.DrawHandler handler);

		// Token: 0x060174CB RID: 95435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174CB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected EditorMeshCanvasDrawer()
		{
		}

		// Token: 0x0401C1FD RID: 115197
		[Token(Token = "0x401C1FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _layer;
	}
}
