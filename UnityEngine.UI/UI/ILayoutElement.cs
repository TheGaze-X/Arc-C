using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public interface ILayoutElement
	{
		// Token: 0x060002D0 RID: 720
		[Token(Token = "0x60002D0")]
		void CalculateLayoutInputHorizontal();

		// Token: 0x060002D1 RID: 721
		[Token(Token = "0x60002D1")]
		void CalculateLayoutInputVertical();

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002D2 RID: 722
		[Token(Token = "0x170000C5")]
		float minWidth { [Token(Token = "0x60002D2")] get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002D3 RID: 723
		[Token(Token = "0x170000C6")]
		float preferredWidth { [Token(Token = "0x60002D3")] get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002D4 RID: 724
		[Token(Token = "0x170000C7")]
		float flexibleWidth { [Token(Token = "0x60002D4")] get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002D5 RID: 725
		[Token(Token = "0x170000C8")]
		float minHeight { [Token(Token = "0x60002D5")] get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002D6 RID: 726
		[Token(Token = "0x170000C9")]
		float preferredHeight { [Token(Token = "0x60002D6")] get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002D7 RID: 727
		[Token(Token = "0x170000CA")]
		float flexibleHeight { [Token(Token = "0x60002D7")] get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002D8 RID: 728
		[Token(Token = "0x170000CB")]
		int layoutPriority { [Token(Token = "0x60002D8")] get; }
	}
}
