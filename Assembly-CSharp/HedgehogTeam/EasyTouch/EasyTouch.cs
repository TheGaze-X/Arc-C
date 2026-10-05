using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public class EasyTouch : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public static event EasyTouch.TouchCancelHandler On_Cancel
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x252BEA0", Offset = "0x252AAA0", VA = "0x18252BEA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x252DEA0", Offset = "0x252CAA0", VA = "0x18252DEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public static event EasyTouch.Cancel2FingersHandler On_Cancel2Fingers
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x252BDE0", Offset = "0x252A9E0", VA = "0x18252BDE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x252DDE0", Offset = "0x252C9E0", VA = "0x18252DDE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000923 RID: 2339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public static event EasyTouch.TouchStartHandler On_TouchStart
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x252D6A0", Offset = "0x252C2A0", VA = "0x18252D6A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x252F6A0", Offset = "0x252E2A0", VA = "0x18252F6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public static event EasyTouch.TouchDownHandler On_TouchDown
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x252D520", Offset = "0x252C120", VA = "0x18252D520")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x252F520", Offset = "0x252E120", VA = "0x18252F520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public static event EasyTouch.TouchUpHandler On_TouchUp
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x252D820", Offset = "0x252C420", VA = "0x18252D820")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x252F820", Offset = "0x252E420", VA = "0x18252F820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public static event EasyTouch.SimpleTapHandler On_SimpleTap
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x252CF20", Offset = "0x252BB20", VA = "0x18252CF20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x252EF20", Offset = "0x252DB20", VA = "0x18252EF20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600092B RID: 2347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public static event EasyTouch.DoubleTapHandler On_DoubleTap
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x252C020", Offset = "0x252AC20", VA = "0x18252C020")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x252E020", Offset = "0x252CC20", VA = "0x18252E020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600092C RID: 2348 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		public static event EasyTouch.LongTapStartHandler On_LongTapStart
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x252C920", Offset = "0x252B520", VA = "0x18252C920")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x252E920", Offset = "0x252D520", VA = "0x18252E920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public static event EasyTouch.LongTapHandler On_LongTap
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x252C9E0", Offset = "0x252B5E0", VA = "0x18252C9E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x252E9E0", Offset = "0x252D5E0", VA = "0x18252E9E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public static event EasyTouch.LongTapEndHandler On_LongTapEnd
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x252C7A0", Offset = "0x252B3A0", VA = "0x18252C7A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x252E7A0", Offset = "0x252D3A0", VA = "0x18252E7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000932 RID: 2354 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		public static event EasyTouch.DragStartHandler On_DragStart
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x252C3E0", Offset = "0x252AFE0", VA = "0x18252C3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x252E3E0", Offset = "0x252CFE0", VA = "0x18252E3E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public static event EasyTouch.DragHandler On_Drag
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x252C4A0", Offset = "0x252B0A0", VA = "0x18252C4A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x252E4A0", Offset = "0x252D0A0", VA = "0x18252E4A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public static event EasyTouch.DragEndHandler On_DragEnd
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x252C260", Offset = "0x252AE60", VA = "0x18252C260")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x252E260", Offset = "0x252CE60", VA = "0x18252E260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000938 RID: 2360 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public static event EasyTouch.SwipeStartHandler On_SwipeStart
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x252D2E0", Offset = "0x252BEE0", VA = "0x18252D2E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x252F2E0", Offset = "0x252DEE0", VA = "0x18252F2E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public static event EasyTouch.SwipeHandler On_Swipe
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x252D3A0", Offset = "0x252BFA0", VA = "0x18252D3A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x252F3A0", Offset = "0x252DFA0", VA = "0x18252F3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public static event EasyTouch.SwipeEndHandler On_SwipeEnd
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x252D160", Offset = "0x252BD60", VA = "0x18252D160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x252F160", Offset = "0x252DD60", VA = "0x18252F160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600093F RID: 2367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public static event EasyTouch.TouchStart2FingersHandler On_TouchStart2Fingers
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x252D5E0", Offset = "0x252C1E0", VA = "0x18252D5E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x252F5E0", Offset = "0x252E1E0", VA = "0x18252F5E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public static event EasyTouch.TouchDown2FingersHandler On_TouchDown2Fingers
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x252D460", Offset = "0x252C060", VA = "0x18252D460")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x252F460", Offset = "0x252E060", VA = "0x18252F460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public static event EasyTouch.TouchUp2FingersHandler On_TouchUp2Fingers
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x252D760", Offset = "0x252C360", VA = "0x18252D760")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x252F760", Offset = "0x252E360", VA = "0x18252F760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public static event EasyTouch.SimpleTap2FingersHandler On_SimpleTap2Fingers
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x252CE60", Offset = "0x252BA60", VA = "0x18252CE60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x252EE60", Offset = "0x252DA60", VA = "0x18252EE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public static event EasyTouch.DoubleTap2FingersHandler On_DoubleTap2Fingers
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x252BF60", Offset = "0x252AB60", VA = "0x18252BF60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x252DF60", Offset = "0x252CB60", VA = "0x18252DF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000949 RID: 2377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public static event EasyTouch.LongTapStart2FingersHandler On_LongTapStart2Fingers
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x252C860", Offset = "0x252B460", VA = "0x18252C860")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x252E860", Offset = "0x252D460", VA = "0x18252E860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600094B RID: 2379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public static event EasyTouch.LongTap2FingersHandler On_LongTap2Fingers
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x252C620", Offset = "0x252B220", VA = "0x18252C620")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x252E620", Offset = "0x252D220", VA = "0x18252E620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public static event EasyTouch.LongTapEnd2FingersHandler On_LongTapEnd2Fingers
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x252C6E0", Offset = "0x252B2E0", VA = "0x18252C6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x252E6E0", Offset = "0x252D2E0", VA = "0x18252E6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public static event EasyTouch.TwistHandler On_Twist
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x252D9A0", Offset = "0x252C5A0", VA = "0x18252D9A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x252F9A0", Offset = "0x252E5A0", VA = "0x18252F9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001B")]
		public static event EasyTouch.TwistEndHandler On_TwistEnd
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x252D8E0", Offset = "0x252C4E0", VA = "0x18252D8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x252F8E0", Offset = "0x252E4E0", VA = "0x18252F8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		public static event EasyTouch.PinchHandler On_Pinch
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x252CDA0", Offset = "0x252B9A0", VA = "0x18252CDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x252EDA0", Offset = "0x252D9A0", VA = "0x18252EDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		public static event EasyTouch.PinchInHandler On_PinchIn
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x252CC20", Offset = "0x252B820", VA = "0x18252CC20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x252EC20", Offset = "0x252D820", VA = "0x18252EC20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public static event EasyTouch.PinchOutHandler On_PinchOut
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x252CCE0", Offset = "0x252B8E0", VA = "0x18252CCE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x252ECE0", Offset = "0x252D8E0", VA = "0x18252ECE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public static event EasyTouch.PinchEndHandler On_PinchEnd
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x252CB60", Offset = "0x252B760", VA = "0x18252CB60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x252EB60", Offset = "0x252D760", VA = "0x18252EB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		public static event EasyTouch.DragStart2FingersHandler On_DragStart2Fingers
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x252C320", Offset = "0x252AF20", VA = "0x18252C320")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x252E320", Offset = "0x252CF20", VA = "0x18252E320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		public static event EasyTouch.Drag2FingersHandler On_Drag2Fingers
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x252C0E0", Offset = "0x252ACE0", VA = "0x18252C0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x252E0E0", Offset = "0x252CCE0", VA = "0x18252E0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public static event EasyTouch.DragEnd2FingersHandler On_DragEnd2Fingers
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x252C1A0", Offset = "0x252ADA0", VA = "0x18252C1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x252E1A0", Offset = "0x252CDA0", VA = "0x18252E1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		public static event EasyTouch.SwipeStart2FingersHandler On_SwipeStart2Fingers
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x252D220", Offset = "0x252BE20", VA = "0x18252D220")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x252F220", Offset = "0x252DE20", VA = "0x18252F220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000024")]
		public static event EasyTouch.Swipe2FingersHandler On_Swipe2Fingers
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x252CFE0", Offset = "0x252BBE0", VA = "0x18252CFE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x252EFE0", Offset = "0x252DBE0", VA = "0x18252EFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000025")]
		public static event EasyTouch.SwipeEnd2FingersHandler On_SwipeEnd2Fingers
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x252D0A0", Offset = "0x252BCA0", VA = "0x18252D0A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x252F0A0", Offset = "0x252DCA0", VA = "0x18252F0A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000026")]
		public static event EasyTouch.EasyTouchIsReadyHandler On_EasyTouchIsReady
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x252C560", Offset = "0x252B160", VA = "0x18252C560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x252E560", Offset = "0x252D160", VA = "0x18252E560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000027")]
		public static event EasyTouch.OverUIElementHandler On_OverUIElement
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x252CAA0", Offset = "0x252B6A0", VA = "0x18252CAA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x252EAA0", Offset = "0x252D6A0", VA = "0x18252EAA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000028")]
		public static event EasyTouch.UIElementTouchUpHandler On_UIElementTouchUp
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x252DA60", Offset = "0x252C660", VA = "0x18252DA60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x252FA60", Offset = "0x252E660", VA = "0x18252FA60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public static EasyTouch instance
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x252DB40", Offset = "0x252C740", VA = "0x18252DB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		public static Gesture current
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x252DB20", Offset = "0x252C720", VA = "0x18252DB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x252BA60", Offset = "0x252A660", VA = "0x18252BA60")]
		public EasyTouch()
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x2525F20", Offset = "0x2524B20", VA = "0x182525F20")]
		private void OnEnable()
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2521E00", Offset = "0x2520A00", VA = "0x182521E00")]
		private void Awake()
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2528AE0", Offset = "0x25276E0", VA = "0x182528AE0")]
		private void Start()
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x25257F0", Offset = "0x25243F0", VA = "0x1825257F0")]
		private void Init()
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2525F60", Offset = "0x2524B60", VA = "0x182525F60")]
		private void OnGUI()
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x252B840", Offset = "0x252A440", VA = "0x18252B840")]
		private void Update()
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x2525E20", Offset = "0x2524A20", VA = "0x182525E20")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x252B0B0", Offset = "0x2529CB0", VA = "0x18252B0B0")]
		private void UpdateTouches(bool realTouch, int touchCount)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x2527E30", Offset = "0x2526A30", VA = "0x182527E30")]
		private void ResetTouches()
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x25260A0", Offset = "0x2524CA0", VA = "0x1825260A0")]
		private void OneFinger(int fingerIndex)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2528A60", Offset = "0x2527660", VA = "0x182528A60")]
		private IEnumerator SingleOrDouble(int fingerIndex)
		{
			return null;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x25221C0", Offset = "0x2520DC0", VA = "0x1825221C0")]
		private void CreateGesture(int touchIndex, EasyTouch.EvtType message, Finger finger, EasyTouch.SwipeDirection swipe, float swipeLength, Vector2 swipeVector)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2528DA0", Offset = "0x25279A0", VA = "0x182528DA0")]
		private void TwoFinger()
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2523080", Offset = "0x2521C80", VA = "0x182523080")]
		private void DetectPinch(float currentDelta)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2522C10", Offset = "0x2521810", VA = "0x182522C10")]
		private void DetecTwist(Vector2 previousDistance, Vector2 currentDistance, float currentDelta)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x25224F0", Offset = "0x25210F0", VA = "0x1825224F0")]
		private void CreateStateEnd2Fingers(EasyTouch.GestureType gesture, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float time, bool realEnd, float fingerDistance, float twist = 0f, float pinch = 0f)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x25289F0", Offset = "0x25275F0", VA = "0x1825289F0")]
		private IEnumerator SingleOrDouble2Fingers()
		{
			return null;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2521E10", Offset = "0x2520A10", VA = "0x182521E10")]
		private void CreateGesture2Finger(EasyTouch.EvtType message, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float actionTime, EasyTouch.SwipeDirection swipe, float swipeLength, Vector2 swipeVector, float twist, float pinch, float twoDistance)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2525680", Offset = "0x2524280", VA = "0x182525680")]
		private int GetTwoFinger(int index)
		{
			return 0;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2525270", Offset = "0x2523E70", VA = "0x182525270")]
		private bool GetTwoFingerPickedObject()
		{
			return default(bool);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2525400", Offset = "0x2524000", VA = "0x182525400")]
		private bool GetTwoFingerPickedUIElement()
		{
			return default(bool);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2527210", Offset = "0x2525E10", VA = "0x182527210")]
		private void RaiseEvent(EasyTouch.EvtType evnt, Gesture gesture)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2524A10", Offset = "0x2523610", VA = "0x182524A10")]
		private bool GetPickedGameObject(Finger finger, bool isTowFinger = false)
		{
			return default(bool);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2524570", Offset = "0x2523170", VA = "0x182524570")]
		private bool GetGameObjectAt(Vector2 position, Camera cam, bool isGuiCam)
		{
			return default(bool);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2524E10", Offset = "0x2523A10", VA = "0x182524E10")]
		private EasyTouch.SwipeDirection GetSwipe(Vector2 start, Vector2 end)
		{
			return EasyTouch.SwipeDirection.None;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x2523620", Offset = "0x2522220", VA = "0x182523620")]
		private bool FingerInTolerance(Finger finger)
		{
			return default(bool);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2525BF0", Offset = "0x25247F0", VA = "0x182525BF0")]
		private bool IsTouchOverNGui(Vector2 position, bool isTwoFingers = false)
		{
			return default(bool);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x25241D0", Offset = "0x2522DD0", VA = "0x1825241D0")]
		private Finger GetFinger(int finderId)
		{
			return null;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2525A70", Offset = "0x2524670", VA = "0x182525A70")]
		private bool IsScreenPositionOverUI(Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x2524230", Offset = "0x2522E30", VA = "0x182524230")]
		private GameObject GetFirstUIElementFromCache()
		{
			return null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x25242A0", Offset = "0x2522EA0", VA = "0x1825242A0")]
		private GameObject GetFirstUIElement(Vector2 position)
		{
			return null;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2525960", Offset = "0x2524560", VA = "0x182525960")]
		public static bool IsFingerOverUIElement(int fingerIndex)
		{
			return default(bool);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2523BB0", Offset = "0x25227B0", VA = "0x182523BB0")]
		public static GameObject GetCurrentPickedUIElement(int fingerIndex, bool isTwoFinger)
		{
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2523A70", Offset = "0x2522670", VA = "0x182523A70")]
		public static GameObject GetCurrentPickedObject(int fingerIndex, bool isTwoFinger)
		{
			return null;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x25242D0", Offset = "0x2522ED0", VA = "0x1825242D0")]
		public static GameObject GetGameObjectAt(Vector2 position, bool isTwoFinger = false)
		{
			return null;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2525160", Offset = "0x2523D60", VA = "0x182525160")]
		public static int GetTouchCount()
		{
			return 0;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2527D50", Offset = "0x2526950", VA = "0x182527D50")]
		public static void ResetTouch(int fingerIndex)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x25284A0", Offset = "0x25270A0", VA = "0x1825284A0")]
		public static void SetEnabled(bool enable)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2524150", Offset = "0x2522D50", VA = "0x182524150")]
		public static bool GetEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2528420", Offset = "0x2527020", VA = "0x182528420")]
		public static void SetEnableUIDetection(bool enable)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x25240D0", Offset = "0x2522CD0", VA = "0x1825240D0")]
		public static bool GetEnableUIDetection()
		{
			return default(bool);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2528970", Offset = "0x2527570", VA = "0x182528970")]
		public static void SetUICompatibily(bool value)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x25256F0", Offset = "0x25242F0", VA = "0x1825256F0")]
		public static bool GetUIComptability()
		{
			return default(bool);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x2528020", Offset = "0x2526C20", VA = "0x182528020")]
		public static void SetAutoUpdateUI(bool value)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x2523910", Offset = "0x2522510", VA = "0x182523910")]
		public static bool GetAutoUpdateUI()
		{
			return default(bool);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x25286F0", Offset = "0x25272F0", VA = "0x1825286F0")]
		public static void SetNGUICompatibility(bool value)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x2524990", Offset = "0x2523590", VA = "0x182524990")]
		public static bool GetNGUICompatibility()
		{
			return default(bool);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x25282A0", Offset = "0x2526EA0", VA = "0x1825282A0")]
		public static void SetEnableAutoSelect(bool value)
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2523F50", Offset = "0x2522B50", VA = "0x182523F50")]
		public static bool GetEnableAutoSelect()
		{
			return default(bool);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2527FA0", Offset = "0x2526BA0", VA = "0x182527FA0")]
		public static void SetAutoUpdatePickedObject(bool value)
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x2523890", Offset = "0x2522490", VA = "0x182523890")]
		public static bool GetAutoUpdatePickedObject()
		{
			return default(bool);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2527F20", Offset = "0x2526B20", VA = "0x182527F20")]
		public static void Set3DPickableLayer(LayerMask mask)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2523780", Offset = "0x2522380", VA = "0x182523780")]
		public static LayerMask Get3DPickableLayer()
		{
			return default(LayerMask);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2521D10", Offset = "0x2520910", VA = "0x182521D10")]
		public static void AddCamera(Camera cam, bool guiCam = false)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2527BB0", Offset = "0x25267B0", VA = "0x182527BB0")]
		public static void RemoveCamera(Camera cam)
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2523990", Offset = "0x2522590", VA = "0x182523990")]
		public static Camera GetCamera(int index = 0)
		{
			return null;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x25281A0", Offset = "0x2526DA0", VA = "0x1825281A0")]
		public static void SetEnable2DCollider(bool value)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2523E50", Offset = "0x2522A50", VA = "0x182523E50")]
		public static bool GetEnable2DCollider()
		{
			return default(bool);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2527EA0", Offset = "0x2526AA0", VA = "0x182527EA0")]
		public static void Set2DPickableLayer(LayerMask mask)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2523670", Offset = "0x2522270", VA = "0x182523670")]
		public static LayerMask Get2DPickableLayer()
		{
			return default(LayerMask);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x25284F0", Offset = "0x25270F0", VA = "0x1825284F0")]
		public static void SetGesturePriority(EasyTouch.GesturePriority value)
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2524810", Offset = "0x2523410", VA = "0x182524810")]
		public static EasyTouch.GesturePriority GetGesturePriority()
		{
			return EasyTouch.GesturePriority.Tap;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x25287F0", Offset = "0x25273F0", VA = "0x1825287F0")]
		public static void SetStationaryTolerance(float tolerance)
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2524D10", Offset = "0x2523910", VA = "0x182524D10")]
		public static float GetStationaryTolerance()
		{
			return 0f;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2528570", Offset = "0x2527170", VA = "0x182528570")]
		public static void SetLongTapTime(float time)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2525770", Offset = "0x2524370", VA = "0x182525770")]
		public static float GetlongTapTime()
		{
			return 0f;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2528120", Offset = "0x2526D20", VA = "0x182528120")]
		public static void SetDoubleTapTime(float time)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2523DD0", Offset = "0x25229D0", VA = "0x182523DD0")]
		public static float GetDoubleTapTime()
		{
			return 0f;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x25280A0", Offset = "0x2526CA0", VA = "0x1825280A0")]
		public static void SetDoubleTapMethod(EasyTouch.DoubleTapDetection detection)
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2523D50", Offset = "0x2522950", VA = "0x182523D50")]
		public static EasyTouch.DoubleTapDetection GetDoubleTapMethod()
		{
			return EasyTouch.DoubleTapDetection.BySystem;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x2528870", Offset = "0x2527470", VA = "0x182528870")]
		public static void SetSwipeTolerance(float tolerance)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x2524D90", Offset = "0x2523990", VA = "0x182524D90")]
		public static float GetSwipeTolerance()
		{
			return 0f;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x2528220", Offset = "0x2526E20", VA = "0x182528220")]
		public static void SetEnable2FingersGesture(bool enable)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x2523ED0", Offset = "0x2522AD0", VA = "0x182523ED0")]
		public static bool GetEnable2FingersGesture()
		{
			return default(bool);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x25288F0", Offset = "0x25274F0", VA = "0x1825288F0")]
		public static void SetTwoFingerPickMethod(EasyTouch.TwoFingerPickMethod pickMethod)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x25251F0", Offset = "0x2523DF0", VA = "0x1825251F0")]
		public static EasyTouch.TwoFingerPickMethod GetTwoFingerPickMethod()
		{
			return EasyTouch.TwoFingerPickMethod.Finger;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x2528320", Offset = "0x2526F20", VA = "0x182528320")]
		public static void SetEnablePinch(bool enable)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2523FD0", Offset = "0x2522BD0", VA = "0x182523FD0")]
		public static bool GetEnablePinch()
		{
			return default(bool);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x25285F0", Offset = "0x25271F0", VA = "0x1825285F0")]
		public static void SetMinPinchLength(float length)
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x2524890", Offset = "0x2523490", VA = "0x182524890")]
		public static float GetMinPinchLength()
		{
			return 0f;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x25283A0", Offset = "0x2526FA0", VA = "0x1825283A0")]
		public static void SetEnableTwist(bool enable)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x2524050", Offset = "0x2522C50", VA = "0x182524050")]
		public static bool GetEnableTwist()
		{
			return default(bool);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2528670", Offset = "0x2527270", VA = "0x182528670")]
		public static void SetMinTwistAngle(float angle)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2524910", Offset = "0x2523510", VA = "0x182524910")]
		public static float GetMinTwistAngle()
		{
			return 0f;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2524C90", Offset = "0x2523890", VA = "0x182524C90")]
		public static bool GetSecondeFingerSimulation()
		{
			return default(bool);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2528770", Offset = "0x2527370", VA = "0x182528770")]
		public static void SetSecondFingerSimulation(bool value)
		{
		}

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x138")]
		private static EasyTouch _instance;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x18")]
		private Gesture _currentGesture;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x20")]
		private List<Gesture> _currentGestures;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x28")]
		public bool enable;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x29")]
		public bool enableRemote;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x2C")]
		public EasyTouch.GesturePriority gesturePriority;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x30")]
		public float StationaryTolerance;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x34")]
		public float longTapTime;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x38")]
		public float swipeTolerance;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x3C")]
		public float minPinchLength;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x40")]
		public float minTwistAngle;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x44")]
		public EasyTouch.DoubleTapDetection doubleTapDetection;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x48")]
		public float doubleTapTime;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x4C")]
		public bool alwaysSendSwipe;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x4D")]
		public bool enable2FingersGesture;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x4E")]
		public bool enableTwist;

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x4F")]
		public bool enablePinch;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x50")]
		public bool enable2FingersSwipe;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x54")]
		public EasyTouch.TwoFingerPickMethod twoFingerPickMethod;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x58")]
		public List<ECamera> touchCameras;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x60")]
		public bool autoSelect;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x64")]
		public LayerMask pickableLayers3D;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x68")]
		public bool enable2D;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x6C")]
		public LayerMask pickableLayers2D;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x70")]
		public bool autoUpdatePickedObject;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x71")]
		public bool allowUIDetection;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x72")]
		public bool enableUIMode;

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x73")]
		public bool autoUpdatePickedUI;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x74")]
		public bool enabledNGuiMode;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x78")]
		public LayerMask nGUILayers;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x80")]
		public List<Camera> nGUICameras;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x88")]
		public bool enableSimulation;

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x8C")]
		public KeyCode twistKey;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x90")]
		public KeyCode swipeKey;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x94")]
		public bool showGuiInspector;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x95")]
		public bool showSelectInspector;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x96")]
		public bool showGestureInspector;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x97")]
		public bool showTwoFingerInspector;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x98")]
		public bool showSecondFingerInspector;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0xA0")]
		private EasyTouchInput input;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0xA8")]
		private Finger[] fingers;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0xB0")]
		public Texture secondFingerTexture;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0xB8")]
		private TwoFingerGesture twoFinger;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0xC0")]
		private int oldTouchCount;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0xC8")]
		private EasyTouch.DoubleTap[] singleDoubleTap;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0xD0")]
		private Finger[] tmpArray;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0xD8")]
		private EasyTouch.PickedObject pickedObject;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0xE0")]
		private List<RaycastResult> uiRaycastResultCache;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0xE8")]
		private PointerEventData uiPointerEventData;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0xF0")]
		private EventSystem uiEventSystem;

		// Token: 0x02000213 RID: 531
		[Token(Token = "0x2000213")]
		[Serializable]
		private class DoubleTap
		{
			// Token: 0x060009C5 RID: 2501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x3203D30", Offset = "0x3202930", VA = "0x183203D30")]
			public void Stop()
			{
			}

			// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DoubleTap()
			{
			}

			// Token: 0x04000BD3 RID: 3027
			[Token(Token = "0x4000BD3")]
			[FieldOffset(Offset = "0x10")]
			public bool inDoubleTap;

			// Token: 0x04000BD4 RID: 3028
			[Token(Token = "0x4000BD4")]
			[FieldOffset(Offset = "0x11")]
			public bool inWait;

			// Token: 0x04000BD5 RID: 3029
			[Token(Token = "0x4000BD5")]
			[FieldOffset(Offset = "0x14")]
			public float time;

			// Token: 0x04000BD6 RID: 3030
			[Token(Token = "0x4000BD6")]
			[FieldOffset(Offset = "0x18")]
			public int count;

			// Token: 0x04000BD7 RID: 3031
			[Token(Token = "0x4000BD7")]
			[FieldOffset(Offset = "0x20")]
			public Finger finger;
		}

		// Token: 0x02000214 RID: 532
		[Token(Token = "0x2000214")]
		private class PickedObject
		{
			// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PickedObject()
			{
			}

			// Token: 0x04000BD8 RID: 3032
			[Token(Token = "0x4000BD8")]
			[FieldOffset(Offset = "0x10")]
			public GameObject pickedObj;

			// Token: 0x04000BD9 RID: 3033
			[Token(Token = "0x4000BD9")]
			[FieldOffset(Offset = "0x18")]
			public Camera pickedCamera;

			// Token: 0x04000BDA RID: 3034
			[Token(Token = "0x4000BDA")]
			[FieldOffset(Offset = "0x20")]
			public bool isGUI;
		}

		// Token: 0x02000215 RID: 533
		// (Invoke) Token: 0x060009C9 RID: 2505
		[Token(Token = "0x2000215")]
		public delegate void TouchCancelHandler(Gesture gesture);

		// Token: 0x02000216 RID: 534
		// (Invoke) Token: 0x060009CD RID: 2509
		[Token(Token = "0x2000216")]
		public delegate void Cancel2FingersHandler(Gesture gesture);

		// Token: 0x02000217 RID: 535
		// (Invoke) Token: 0x060009D1 RID: 2513
		[Token(Token = "0x2000217")]
		public delegate void TouchStartHandler(Gesture gesture);

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x060009D5 RID: 2517
		[Token(Token = "0x2000218")]
		public delegate void TouchDownHandler(Gesture gesture);

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x060009D9 RID: 2521
		[Token(Token = "0x2000219")]
		public delegate void TouchUpHandler(Gesture gesture);

		// Token: 0x0200021A RID: 538
		// (Invoke) Token: 0x060009DD RID: 2525
		[Token(Token = "0x200021A")]
		public delegate void SimpleTapHandler(Gesture gesture);

		// Token: 0x0200021B RID: 539
		// (Invoke) Token: 0x060009E1 RID: 2529
		[Token(Token = "0x200021B")]
		public delegate void DoubleTapHandler(Gesture gesture);

		// Token: 0x0200021C RID: 540
		// (Invoke) Token: 0x060009E5 RID: 2533
		[Token(Token = "0x200021C")]
		public delegate void LongTapStartHandler(Gesture gesture);

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x060009E9 RID: 2537
		[Token(Token = "0x200021D")]
		public delegate void LongTapHandler(Gesture gesture);

		// Token: 0x0200021E RID: 542
		// (Invoke) Token: 0x060009ED RID: 2541
		[Token(Token = "0x200021E")]
		public delegate void LongTapEndHandler(Gesture gesture);

		// Token: 0x0200021F RID: 543
		// (Invoke) Token: 0x060009F1 RID: 2545
		[Token(Token = "0x200021F")]
		public delegate void DragStartHandler(Gesture gesture);

		// Token: 0x02000220 RID: 544
		// (Invoke) Token: 0x060009F5 RID: 2549
		[Token(Token = "0x2000220")]
		public delegate void DragHandler(Gesture gesture);

		// Token: 0x02000221 RID: 545
		// (Invoke) Token: 0x060009F9 RID: 2553
		[Token(Token = "0x2000221")]
		public delegate void DragEndHandler(Gesture gesture);

		// Token: 0x02000222 RID: 546
		// (Invoke) Token: 0x060009FD RID: 2557
		[Token(Token = "0x2000222")]
		public delegate void SwipeStartHandler(Gesture gesture);

		// Token: 0x02000223 RID: 547
		// (Invoke) Token: 0x06000A01 RID: 2561
		[Token(Token = "0x2000223")]
		public delegate void SwipeHandler(Gesture gesture);

		// Token: 0x02000224 RID: 548
		// (Invoke) Token: 0x06000A05 RID: 2565
		[Token(Token = "0x2000224")]
		public delegate void SwipeEndHandler(Gesture gesture);

		// Token: 0x02000225 RID: 549
		// (Invoke) Token: 0x06000A09 RID: 2569
		[Token(Token = "0x2000225")]
		public delegate void TouchStart2FingersHandler(Gesture gesture);

		// Token: 0x02000226 RID: 550
		// (Invoke) Token: 0x06000A0D RID: 2573
		[Token(Token = "0x2000226")]
		public delegate void TouchDown2FingersHandler(Gesture gesture);

		// Token: 0x02000227 RID: 551
		// (Invoke) Token: 0x06000A11 RID: 2577
		[Token(Token = "0x2000227")]
		public delegate void TouchUp2FingersHandler(Gesture gesture);

		// Token: 0x02000228 RID: 552
		// (Invoke) Token: 0x06000A15 RID: 2581
		[Token(Token = "0x2000228")]
		public delegate void SimpleTap2FingersHandler(Gesture gesture);

		// Token: 0x02000229 RID: 553
		// (Invoke) Token: 0x06000A19 RID: 2585
		[Token(Token = "0x2000229")]
		public delegate void DoubleTap2FingersHandler(Gesture gesture);

		// Token: 0x0200022A RID: 554
		// (Invoke) Token: 0x06000A1D RID: 2589
		[Token(Token = "0x200022A")]
		public delegate void LongTapStart2FingersHandler(Gesture gesture);

		// Token: 0x0200022B RID: 555
		// (Invoke) Token: 0x06000A21 RID: 2593
		[Token(Token = "0x200022B")]
		public delegate void LongTap2FingersHandler(Gesture gesture);

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x06000A25 RID: 2597
		[Token(Token = "0x200022C")]
		public delegate void LongTapEnd2FingersHandler(Gesture gesture);

		// Token: 0x0200022D RID: 557
		// (Invoke) Token: 0x06000A29 RID: 2601
		[Token(Token = "0x200022D")]
		public delegate void TwistHandler(Gesture gesture);

		// Token: 0x0200022E RID: 558
		// (Invoke) Token: 0x06000A2D RID: 2605
		[Token(Token = "0x200022E")]
		public delegate void TwistEndHandler(Gesture gesture);

		// Token: 0x0200022F RID: 559
		// (Invoke) Token: 0x06000A31 RID: 2609
		[Token(Token = "0x200022F")]
		public delegate void PinchInHandler(Gesture gesture);

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x06000A35 RID: 2613
		[Token(Token = "0x2000230")]
		public delegate void PinchOutHandler(Gesture gesture);

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x06000A39 RID: 2617
		[Token(Token = "0x2000231")]
		public delegate void PinchEndHandler(Gesture gesture);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x06000A3D RID: 2621
		[Token(Token = "0x2000232")]
		public delegate void PinchHandler(Gesture gesture);

		// Token: 0x02000233 RID: 563
		// (Invoke) Token: 0x06000A41 RID: 2625
		[Token(Token = "0x2000233")]
		public delegate void DragStart2FingersHandler(Gesture gesture);

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x06000A45 RID: 2629
		[Token(Token = "0x2000234")]
		public delegate void Drag2FingersHandler(Gesture gesture);

		// Token: 0x02000235 RID: 565
		// (Invoke) Token: 0x06000A49 RID: 2633
		[Token(Token = "0x2000235")]
		public delegate void DragEnd2FingersHandler(Gesture gesture);

		// Token: 0x02000236 RID: 566
		// (Invoke) Token: 0x06000A4D RID: 2637
		[Token(Token = "0x2000236")]
		public delegate void SwipeStart2FingersHandler(Gesture gesture);

		// Token: 0x02000237 RID: 567
		// (Invoke) Token: 0x06000A51 RID: 2641
		[Token(Token = "0x2000237")]
		public delegate void Swipe2FingersHandler(Gesture gesture);

		// Token: 0x02000238 RID: 568
		// (Invoke) Token: 0x06000A55 RID: 2645
		[Token(Token = "0x2000238")]
		public delegate void SwipeEnd2FingersHandler(Gesture gesture);

		// Token: 0x02000239 RID: 569
		// (Invoke) Token: 0x06000A59 RID: 2649
		[Token(Token = "0x2000239")]
		public delegate void EasyTouchIsReadyHandler();

		// Token: 0x0200023A RID: 570
		// (Invoke) Token: 0x06000A5D RID: 2653
		[Token(Token = "0x200023A")]
		public delegate void OverUIElementHandler(Gesture gesture);

		// Token: 0x0200023B RID: 571
		// (Invoke) Token: 0x06000A61 RID: 2657
		[Token(Token = "0x200023B")]
		public delegate void UIElementTouchUpHandler(Gesture gesture);

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		public enum GesturePriority
		{
			// Token: 0x04000BDC RID: 3036
			[Token(Token = "0x4000BDC")]
			Tap,
			// Token: 0x04000BDD RID: 3037
			[Token(Token = "0x4000BDD")]
			Slips
		}

		// Token: 0x0200023D RID: 573
		[Token(Token = "0x200023D")]
		public enum DoubleTapDetection
		{
			// Token: 0x04000BDF RID: 3039
			[Token(Token = "0x4000BDF")]
			BySystem,
			// Token: 0x04000BE0 RID: 3040
			[Token(Token = "0x4000BE0")]
			ByTime
		}

		// Token: 0x0200023E RID: 574
		[Token(Token = "0x200023E")]
		public enum GestureType
		{
			// Token: 0x04000BE2 RID: 3042
			[Token(Token = "0x4000BE2")]
			Tap,
			// Token: 0x04000BE3 RID: 3043
			[Token(Token = "0x4000BE3")]
			Drag,
			// Token: 0x04000BE4 RID: 3044
			[Token(Token = "0x4000BE4")]
			Swipe,
			// Token: 0x04000BE5 RID: 3045
			[Token(Token = "0x4000BE5")]
			None,
			// Token: 0x04000BE6 RID: 3046
			[Token(Token = "0x4000BE6")]
			LongTap,
			// Token: 0x04000BE7 RID: 3047
			[Token(Token = "0x4000BE7")]
			Pinch,
			// Token: 0x04000BE8 RID: 3048
			[Token(Token = "0x4000BE8")]
			Twist,
			// Token: 0x04000BE9 RID: 3049
			[Token(Token = "0x4000BE9")]
			Cancel,
			// Token: 0x04000BEA RID: 3050
			[Token(Token = "0x4000BEA")]
			Acquisition
		}

		// Token: 0x0200023F RID: 575
		[Token(Token = "0x200023F")]
		public enum SwipeDirection
		{
			// Token: 0x04000BEC RID: 3052
			[Token(Token = "0x4000BEC")]
			None,
			// Token: 0x04000BED RID: 3053
			[Token(Token = "0x4000BED")]
			Left,
			// Token: 0x04000BEE RID: 3054
			[Token(Token = "0x4000BEE")]
			Right,
			// Token: 0x04000BEF RID: 3055
			[Token(Token = "0x4000BEF")]
			Up,
			// Token: 0x04000BF0 RID: 3056
			[Token(Token = "0x4000BF0")]
			Down,
			// Token: 0x04000BF1 RID: 3057
			[Token(Token = "0x4000BF1")]
			UpLeft,
			// Token: 0x04000BF2 RID: 3058
			[Token(Token = "0x4000BF2")]
			UpRight,
			// Token: 0x04000BF3 RID: 3059
			[Token(Token = "0x4000BF3")]
			DownLeft,
			// Token: 0x04000BF4 RID: 3060
			[Token(Token = "0x4000BF4")]
			DownRight,
			// Token: 0x04000BF5 RID: 3061
			[Token(Token = "0x4000BF5")]
			Other,
			// Token: 0x04000BF6 RID: 3062
			[Token(Token = "0x4000BF6")]
			All
		}

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		public enum TwoFingerPickMethod
		{
			// Token: 0x04000BF8 RID: 3064
			[Token(Token = "0x4000BF8")]
			Finger,
			// Token: 0x04000BF9 RID: 3065
			[Token(Token = "0x4000BF9")]
			Average
		}

		// Token: 0x02000241 RID: 577
		[Token(Token = "0x2000241")]
		public enum EvtType
		{
			// Token: 0x04000BFB RID: 3067
			[Token(Token = "0x4000BFB")]
			None,
			// Token: 0x04000BFC RID: 3068
			[Token(Token = "0x4000BFC")]
			On_TouchStart,
			// Token: 0x04000BFD RID: 3069
			[Token(Token = "0x4000BFD")]
			On_TouchDown,
			// Token: 0x04000BFE RID: 3070
			[Token(Token = "0x4000BFE")]
			On_TouchUp,
			// Token: 0x04000BFF RID: 3071
			[Token(Token = "0x4000BFF")]
			On_SimpleTap,
			// Token: 0x04000C00 RID: 3072
			[Token(Token = "0x4000C00")]
			On_DoubleTap,
			// Token: 0x04000C01 RID: 3073
			[Token(Token = "0x4000C01")]
			On_LongTapStart,
			// Token: 0x04000C02 RID: 3074
			[Token(Token = "0x4000C02")]
			On_LongTap,
			// Token: 0x04000C03 RID: 3075
			[Token(Token = "0x4000C03")]
			On_LongTapEnd,
			// Token: 0x04000C04 RID: 3076
			[Token(Token = "0x4000C04")]
			On_DragStart,
			// Token: 0x04000C05 RID: 3077
			[Token(Token = "0x4000C05")]
			On_Drag,
			// Token: 0x04000C06 RID: 3078
			[Token(Token = "0x4000C06")]
			On_DragEnd,
			// Token: 0x04000C07 RID: 3079
			[Token(Token = "0x4000C07")]
			On_SwipeStart,
			// Token: 0x04000C08 RID: 3080
			[Token(Token = "0x4000C08")]
			On_Swipe,
			// Token: 0x04000C09 RID: 3081
			[Token(Token = "0x4000C09")]
			On_SwipeEnd,
			// Token: 0x04000C0A RID: 3082
			[Token(Token = "0x4000C0A")]
			On_TouchStart2Fingers,
			// Token: 0x04000C0B RID: 3083
			[Token(Token = "0x4000C0B")]
			On_TouchDown2Fingers,
			// Token: 0x04000C0C RID: 3084
			[Token(Token = "0x4000C0C")]
			On_TouchUp2Fingers,
			// Token: 0x04000C0D RID: 3085
			[Token(Token = "0x4000C0D")]
			On_SimpleTap2Fingers,
			// Token: 0x04000C0E RID: 3086
			[Token(Token = "0x4000C0E")]
			On_DoubleTap2Fingers,
			// Token: 0x04000C0F RID: 3087
			[Token(Token = "0x4000C0F")]
			On_LongTapStart2Fingers,
			// Token: 0x04000C10 RID: 3088
			[Token(Token = "0x4000C10")]
			On_LongTap2Fingers,
			// Token: 0x04000C11 RID: 3089
			[Token(Token = "0x4000C11")]
			On_LongTapEnd2Fingers,
			// Token: 0x04000C12 RID: 3090
			[Token(Token = "0x4000C12")]
			On_Twist,
			// Token: 0x04000C13 RID: 3091
			[Token(Token = "0x4000C13")]
			On_TwistEnd,
			// Token: 0x04000C14 RID: 3092
			[Token(Token = "0x4000C14")]
			On_Pinch,
			// Token: 0x04000C15 RID: 3093
			[Token(Token = "0x4000C15")]
			On_PinchIn,
			// Token: 0x04000C16 RID: 3094
			[Token(Token = "0x4000C16")]
			On_PinchOut,
			// Token: 0x04000C17 RID: 3095
			[Token(Token = "0x4000C17")]
			On_PinchEnd,
			// Token: 0x04000C18 RID: 3096
			[Token(Token = "0x4000C18")]
			On_DragStart2Fingers,
			// Token: 0x04000C19 RID: 3097
			[Token(Token = "0x4000C19")]
			On_Drag2Fingers,
			// Token: 0x04000C1A RID: 3098
			[Token(Token = "0x4000C1A")]
			On_DragEnd2Fingers,
			// Token: 0x04000C1B RID: 3099
			[Token(Token = "0x4000C1B")]
			On_SwipeStart2Fingers,
			// Token: 0x04000C1C RID: 3100
			[Token(Token = "0x4000C1C")]
			On_Swipe2Fingers,
			// Token: 0x04000C1D RID: 3101
			[Token(Token = "0x4000C1D")]
			On_SwipeEnd2Fingers,
			// Token: 0x04000C1E RID: 3102
			[Token(Token = "0x4000C1E")]
			On_EasyTouchIsReady,
			// Token: 0x04000C1F RID: 3103
			[Token(Token = "0x4000C1F")]
			On_Cancel,
			// Token: 0x04000C20 RID: 3104
			[Token(Token = "0x4000C20")]
			On_Cancel2Fingers,
			// Token: 0x04000C21 RID: 3105
			[Token(Token = "0x4000C21")]
			On_OverUIElement,
			// Token: 0x04000C22 RID: 3106
			[Token(Token = "0x4000C22")]
			On_UIElementTouchUp
		}
	}
}
