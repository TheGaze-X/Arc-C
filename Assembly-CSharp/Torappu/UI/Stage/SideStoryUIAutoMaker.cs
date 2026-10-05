using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage
{
	// Token: 0x02006804 RID: 26628
	[Token(Token = "0x2006804")]
	[CreateAssetMenu(menuName = "Torappu/AutoMaker/SideStory UI AutoMaker")]
	public class SideStoryUIAutoMaker : ScriptableObject
	{
		// Token: 0x06026284 RID: 156292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026284")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public SideStoryUIAutoMaker()
		{
		}

		// Token: 0x04035BDB RID: 220123
		[Token(Token = "0x4035BDB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _retroId;

		// Token: 0x04035BDC RID: 220124
		[Token(Token = "0x4035BDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _fromActId;
	}
}
