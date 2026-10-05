using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[RequireComponent(typeof(CanvasScaler))]
	[RequireComponent(typeof(Canvas))]
	public class StandaloneCanvasScalerInfo : MonoBehaviour
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
		public bool CheckCanvasScalerAvail()
		{
			return default(bool);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StandaloneCanvasScalerInfo()
		{
		}

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _canvasAvail;
	}
}
