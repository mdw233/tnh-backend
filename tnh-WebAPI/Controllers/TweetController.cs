using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace tnh_WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("tweet")]
    public class TweetController : Controller
    {
        [HttpGet]
        [Route("search")]
        public IEnumerable<dynamic> Search(string q, string geocode)
        {
            var tweets = new List<dynamic>();
            tweets.Add(JsonConvert.DeserializeObject(@"{
            'created_at': 'Mon Dec 18 00:16:42 +0000 2017',
            'id': 942549142919958528,
            'id_str': '942549142919958528',
            'text': 'Yes, these are the 2017 Steelers',
            'truncated': false,
            'entities': {
                'hashtags': [],
                'symbols': [],
                'user_mentions': [],
                'urls': []
    },
            'metadata': {
                'iso_language_code': 'en',
                'result_type': 'recent'
            },
            'source': '<a href=\'http://twitter.com/download/iphone\' rel=\'nofollow\'>Twitter for iPhone</a>',
            'in_reply_to_status_id': null,
            'in_reply_to_status_id_str': null,
            'in_reply_to_user_id': null,
            'in_reply_to_user_id_str': null,
            'in_reply_to_screen_name': null,
            'user': {
                'id': 174398353,
                'id_str': '174398353',
                'name': 'Matt Gajtka',
                'screen_name': 'MattGajtka',
                'location': 'Pittsburgh, PA',
                'description': '✝️🇵🇱 Family man. Mind, body, spirit, hair. @DKPghSports #Pens reporter/radio host, @RiversEdgePGH host, @PetersHockey PxP. Alum of @MarshallU, @RMU, @USHL.',
                'url': 'https://t.co/e7ahuyi2Bw',
                'entities': {
                    'url': {
                        'urls': [
                            {
                                'url': 'https://t.co/e7ahuyi2Bw',
                                'expanded_url': 'http://dkpittsburghsports.com/author/matt-gajtka/',
                                'display_url': 'dkpittsburghsports.com/author/matt-ga…',
                                'indices': [
                                    0,
                                    23
                                ]
                            }
                        ]
                    },
                    'description': {
                        'urls': []
                    }
                },
                'protected': false,
                'followers_count': 11126,
                'friends_count': 1884,
                'listed_count': 253,
                'created_at': 'Tue Aug 03 20:55:40 +0000 2010',
                'favourites_count': 20587,
                'utc_offset': -28800,
                'time_zone': 'Pacific Time (US & Canada)',
                'geo_enabled': true,
                'verified': false,
                'statuses_count': 86779,
                'lang': 'en',
                'contributors_enabled': false,
                'is_translator': false,
                'is_translation_enabled': false,
                'profile_background_color': '000000',
                'profile_background_image_url': 'http://abs.twimg.com/images/themes/theme5/bg.gif',
                'profile_background_image_url_https': 'https://abs.twimg.com/images/themes/theme5/bg.gif',
                'profile_background_tile': false,
                'profile_image_url': 'http://pbs.twimg.com/profile_images/884513716892512257/fsI5JbR4_normal.jpg',
                'profile_image_url_https': 'https://pbs.twimg.com/profile_images/884513716892512257/fsI5JbR4_normal.jpg',
                'profile_banner_url': 'https://pbs.twimg.com/profile_banners/174398353/1503167753',
                'profile_link_color': '4A913C',
                'profile_sidebar_border_color': '000000',
                'profile_sidebar_fill_color': '000000',
                'profile_text_color': '000000',
                'profile_use_background_image': false,
                'has_extended_profile': true,
                'default_profile': false,
                'default_profile_image': false,
                'following': null,
                'follow_request_sent': null,
                'notifications': null,
                'translator_type': 'none'
            },
            'geo': null,
            'coordinates': null,
            'place': {
                'id': 'dca81e19244d5c54',
                'url': 'https://api.twitter.com/1.1/geo/id/dca81e19244d5c54.json',
                'place_type': 'city',
                'name': 'West View',
                'full_name': 'West View, PA',
                'country_code': 'US',
                'country': 'United States',
                'contained_within': [],
                'bounding_box': {
                    'type': 'Polygon',
                    'coordinates': [
                        [
                            [
                                -80.049045,
                                40.509079
                            ],
                            [
                                -80.0177436,
                                40.509079
                            ],
                            [
                                -80.0177436,
                                40.527793
                            ],
                            [
                                -80.049045,
                                40.527793
                            ]
                        ]
                    ]
                },
                'attributes': {}
            },
            'contributors': null,
            'is_quote_status': false,
            'retweet_count': 0,
            'favorite_count': 5,
            'favorited': false,
            'retweeted': false,
            'lang': 'en'
            }"));

            tweets.Add(JsonConvert.DeserializeObject(@"
             {
                        'created_at': 'Mon Dec 18 00:16:42 + 0000 2017',
                        'id': 942549142919958528,
                        'id_str': '942549142919958528',
                        'text': 'Yes, these are the 2017 Steelers',
                        'truncated': false,
                        'entities': {
                            'hashtags': [],
                            'symbols': [],
                            'user_mentions': [],
                            'urls': []
                },
                        'metadata': {
                            'iso_language_code': 'en',
                            'result_type': 'recent'
                        },
                        'source': '<a href=\'http://twitter.com/download/iphone\' rel=\'nofollow\'>Twitter for iPhone</a>',
                        'in_reply_to_status_id': null,
                        'in_reply_to_status_id_str': null,
                        'in_reply_to_user_id': null,
                        'in_reply_to_user_id_str': null,
                        'in_reply_to_screen_name': null,
                        'user': {
                            'id': 174398353,
                            'id_str': '174398353',
                            'name': 'Matt Gajtka',
                            'screen_name': 'MattGajtka',
                            'location': 'Pittsburgh, PA',
                            'description': '✝️🇵🇱 Family man. Mind, body, spirit, hair. @DKPghSports #Pens reporter/radio host, @RiversEdgePGH host, @PetersHockey PxP. Alum of @MarshallU, @RMU, @USHL.',
                            'url': 'https://t.co/e7ahuyi2Bw',
                            'entities': {
                                'url': {
                                    'urls': [
                                        {
                                            'url': 'https://t.co/e7ahuyi2Bw',
                                            'expanded_url': 'http://dkpittsburghsports.com/author/matt-gajtka/',
                                            'display_url': 'dkpittsburghsports.com/author/matt-ga…',
                                            'indices': [
                                                0,
                                                23
                                            ]
                                        }
                                    ]
                                },
                                'description': {
                                    'urls': []
                                }
                            },
                            'protected': false,
                            'followers_count': 11126,
                            'friends_count': 1884,
                            'listed_count': 253,
                            'created_at': 'Tue Aug 03 20:55:40 +0000 2010',
                            'favourites_count': 20587,
                            'utc_offset': -28800,
                            'time_zone': 'Pacific Time (US & Canada)',
                            'geo_enabled': true,
                            'verified': false,
                            'statuses_count': 86779,
                            'lang': 'en',
                            'contributors_enabled': false,
                            'is_translator': false,
                            'is_translation_enabled': false,
                            'profile_background_color': '000000',
                            'profile_background_image_url': 'http://abs.twimg.com/images/themes/theme5/bg.gif',
                            'profile_background_image_url_https': 'https://abs.twimg.com/images/themes/theme5/bg.gif',
                            'profile_background_tile': false,
                            'profile_image_url': 'http://pbs.twimg.com/profile_images/884513716892512257/fsI5JbR4_normal.jpg',
                            'profile_image_url_https': 'https://pbs.twimg.com/profile_images/884513716892512257/fsI5JbR4_normal.jpg',
                            'profile_banner_url': 'https://pbs.twimg.com/profile_banners/174398353/1503167753',
                            'profile_link_color': '4A913C',
                            'profile_sidebar_border_color': '000000',
                            'profile_sidebar_fill_color': '000000',
                            'profile_text_color': '000000',
                            'profile_use_background_image': false,
                            'has_extended_profile': true,
                            'default_profile': false,
                            'default_profile_image': false,
                            'following': null,
                            'follow_request_sent': null,
                            'notifications': null,
                            'translator_type': 'none'
                        },
                        'geo': null,
                        'coordinates': null,
                        'place': {
                            'id': 'dca81e19244d5c54',
                            'url': 'https://api.twitter.com/1.1/geo/id/dca81e19244d5c54.json',
                            'place_type': 'city',
                            'name': 'West View',
                            'full_name': 'West View, PA',
                            'country_code': 'US',
                            'country': 'United States',
                            'contained_within': [],
                            'bounding_box': {
                                'type': 'Polygon',
                                'coordinates': [
                                    [
                                        [
                                            -80.049045,
                                            40.509079
                                        ],
                                        [
                                            -80.0177436,
                                            40.509079
                                        ],
                                        [
                                            -80.0177436,
                                            40.527793
                                        ],
                                        [
                                            -80.049045,
                                            40.527793
                                        ]
                                    ]
                                ]
                            },
                            'attributes': {}
                        },
                        'contributors': null,
                        'is_quote_status': false,
                        'retweet_count': 0,
                        'favorite_count': 5,
                        'favorited': false,
                        'retweeted': false,
                        'lang': 'en'
                    }
            "));

            return tweets;
        }
    }
}