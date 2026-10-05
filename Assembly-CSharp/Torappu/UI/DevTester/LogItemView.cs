using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F1 RID: 20721
	[Token(Token = "0x20050F1")]
	public class LogItemView : MonoBehaviour
	{
		// Token: 0x0601E9FF RID: 125439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9FF")]
		[Address(RVA = "0x1862B80", Offset = "0x1861780", VA = "0x181862B80")]
		public void LoadData(UIDebugLogger.Log logViewModel)
		{
		}

		// Token: 0x0601EA00 RID: 125440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA00")]
		[Address(RVA = "0x1862D60", Offset = "0x1861960", VA = "0x181862D60")]
		public void OnClick()
		{
		}

		// Token: 0x0601EA01 RID: 125441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA01")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LogItemView()
		{
		}

		// Token: 0x040290C1 RID: 168129
		[Token(Token = "0x40290C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _logString;

		// Token: 0x040290C2 RID: 168130
		[Token(Token = "0x40290C2")]
		[FieldOffset(Offset = "0x20")]
		private UIDebugLogger.Log m_cacheViewModel;

		// Token: 0x040290C3 RID: 168131
		[Token(Token = "0x40290C3")]
		[FieldOffset(Offset = "0x28")]
		private Action<string> m_clickCallback;
	}
}
