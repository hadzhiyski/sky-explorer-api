using SkyExplorer.Data.Models;

namespace SkyExplorer.Data.Seeder;

internal class CountriesSeed
{
    public static readonly IEnumerable<Country> Data = new[]
    {
        new Country
        {
            Name = "Afghanistan", Alpha2Code = "AF",
            BoundingBox = new BoundingBox
                {MinLatitude = 29.3772, MaxLatitude = 38.4910682, MinLongitude = 60.5176034, MaxLongitude = 74.889862,}
        },
        new Country
        {
            Name = "Åland Islands", Alpha2Code = "AX",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 59.4541578, MaxLatitude = 60.87665, MinLongitude = 19.0832098, MaxLongitude = 21.3456556,
            }
        },
        new Country
        {
            Name = "Albania", Alpha2Code = "AL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 39.6448625, MaxLatitude = 42.6610848, MinLongitude = 19.1246095,
                MaxLongitude = 21.0574335,
            }
        },
        new Country
        {
            Name = "Algeria", Alpha2Code = "DZ",
            BoundingBox = new BoundingBox
                {MinLatitude = 18.968147, MaxLatitude = 37.2962055, MinLongitude = -8.668908, MaxLongitude = 11.997337,}
        },
        new Country
        {
            Name = "American Samoa", Alpha2Code = "AS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -14.7608358, MaxLatitude = -10.8449746, MinLongitude = -171.2951296,
                MaxLongitude = -167.9322899,
            }
        },
        new Country
        {
            Name = "Andorra", Alpha2Code = "AD",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 42.4288238, MaxLatitude = 42.6559357, MinLongitude = 1.4135781, MaxLongitude = 1.7863837,
            }
        },
        new Country
        {
            Name = "Angola", Alpha2Code = "AO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -18.038945, MaxLatitude = -4.3880634, MinLongitude = 11.4609793,
                MaxLongitude = 24.0878856,
            }
        },
        new Country
        {
            Name = "Anguilla", Alpha2Code = "AI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 18.0615454, MaxLatitude = 18.7951194, MinLongitude = -63.6391992,
                MaxLongitude = -62.7125449,
            }
        },
        new Country
        {
            Name = "Antarctica", Alpha2Code = "AQ",
            BoundingBox = new BoundingBox
                {MinLatitude = -85.0511287, MaxLatitude = -60, MinLongitude = -180, MaxLongitude = 180,}
        },
        new Country
        {
            Name = "Antigua and Barbuda", Alpha2Code = "AG",
            BoundingBox = new BoundingBox
                {MinLatitude = 16.7573901, MaxLatitude = 17.929, MinLongitude = -62.5536517, MaxLongitude = -61.447857,}
        },
        new Country
        {
            Name = "Argentina", Alpha2Code = "AR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -55.1850761, MaxLatitude = -21.781168, MinLongitude = -73.5600329,
                MaxLongitude = -53.6374515,
            }
        },
        new Country
        {
            Name = "Armenia", Alpha2Code = "AM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 38.8404775, MaxLatitude = 41.300712, MinLongitude = 43.4471395, MaxLongitude = 46.6333087,
            }
        },
        new Country
        {
            Name = "Aruba", Alpha2Code = "AW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.1702998, MaxLatitude = 12.8102998, MinLongitude = -70.2809842,
                MaxLongitude = -69.6409842,
            }
        },
        new Country
        {
            Name = "Australia", Alpha2Code = "AU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -55.3228175, MaxLatitude = -9.0882278, MinLongitude = 72.2460938,
                MaxLongitude = 168.2249543,
            }
        },
        new Country
        {
            Name = "Austria", Alpha2Code = "AT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 46.3722761, MaxLatitude = 49.0205305, MinLongitude = 9.5307487, MaxLongitude = 17.160776,
            }
        },
        new Country
        {
            Name = "Azerbaijan", Alpha2Code = "AZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 38.3929551, MaxLatitude = 41.9502947, MinLongitude = 44.7633701,
                MaxLongitude = 51.0090302,
            }
        },
        new Country
        {
            Name = "Bahamas", Alpha2Code = "BS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 20.7059846, MaxLatitude = 27.4734551, MinLongitude = -80.7001941,
                MaxLongitude = -72.4477521,
            }
        },
        new Country
        {
            Name = "Bahrain", Alpha2Code = "BH",
            BoundingBox = new BoundingBox
                {MinLatitude = 25.535, MaxLatitude = 26.6872444, MinLongitude = 50.2697989, MaxLongitude = 50.9233693,}
        },
        new Country
        {
            Name = "Bangladesh", Alpha2Code = "BD",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 20.3756582, MaxLatitude = 26.6382534, MinLongitude = 88.0075306,
                MaxLongitude = 92.6804979,
            }
        },
        new Country
        {
            Name = "Barbados", Alpha2Code = "BB",
            BoundingBox = new BoundingBox
                {MinLatitude = 12.845, MaxLatitude = 13.535, MinLongitude = -59.8562115, MaxLongitude = -59.2147175,}
        },
        new Country
        {
            Name = "Belarus", Alpha2Code = "BY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 51.2575982, MaxLatitude = 56.17218, MinLongitude = 23.1783344, MaxLongitude = 32.7627809,
            }
        },
        new Country
        {
            Name = "Belgium", Alpha2Code = "BE",
            BoundingBox = new BoundingBox
                {MinLatitude = 49.4969821, MaxLatitude = 51.5516667, MinLongitude = 2.3889137, MaxLongitude = 6.408097,}
        },
        new Country
        {
            Name = "Belize", Alpha2Code = "BZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 15.8857286, MaxLatitude = 18.496001, MinLongitude = -89.2262083,
                MaxLongitude = -87.3098494,
            }
        },
        new Country
        {
            Name = "Benin", Alpha2Code = "BJ",
            BoundingBox = new BoundingBox
                {MinLatitude = 6.0398696, MaxLatitude = 12.4092447, MinLongitude = 0.776667, MaxLongitude = 3.843343,}
        },
        new Country
        {
            Name = "Bermuda", Alpha2Code = "BM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 32.0469651, MaxLatitude = 32.5913693, MinLongitude = -65.1232222,
                MaxLongitude = -64.4109842,
            }
        },
        new Country
        {
            Name = "Bhutan", Alpha2Code = "BT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 26.702016, MaxLatitude = 28.246987, MinLongitude = 88.7464724, MaxLongitude = 92.1252321,
            }
        },
        new Country
        {
            Name = "Bolivia, Plurinational State of", Alpha2Code = "BO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -22.8982742, MaxLatitude = -9.6689438, MinLongitude = -69.6450073, MaxLongitude = -57.453,
            }
        },
        new Country
        {
            Name = "Bosnia and Herzegovina", Alpha2Code = "BA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 42.5553114, MaxLatitude = 45.2764135, MinLongitude = 15.7287433,
                MaxLongitude = 19.6237311,
            }
        },
        new Country
        {
            Name = "Botswana", Alpha2Code = "BW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -26.9059669, MaxLatitude = -17.778137, MinLongitude = 19.9986474,
                MaxLongitude = 29.375304,
            }
        },
        new Country
        {
            Name = "Bouvet Island", Alpha2Code = "BV",
            BoundingBox = new BoundingBox
                {MinLatitude = -54.654, MaxLatitude = -54.187, MinLongitude = 2.9345531, MaxLongitude = 3.7791099,}
        },
        new Country
        {
            Name = "Brazil", Alpha2Code = "BR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -33.8689056, MaxLatitude = 5.2842873, MinLongitude = -73.9830625,
                MaxLongitude = -28.6341164,
            }
        },
        new Country
        {
            Name = "British Indian Ocean Territory", Alpha2Code = "IO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -7.6454079, MaxLatitude = -5.037066, MinLongitude = 71.036504, MaxLongitude = 72.7020157,
            }
        },
        new Country
        {
            Name = "Brunei Darussalam", Alpha2Code = "BN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 4.002508, MaxLatitude = 5.1011857, MinLongitude = 114.0758734, MaxLongitude = 115.3635623,
            }
        },
        new Country
        {
            Name = "Bulgaria", Alpha2Code = "BG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.2353929, MaxLatitude = 44.2167064, MinLongitude = 22.3571459,
                MaxLongitude = 28.8875409,
            }
        },
        new Country
        {
            Name = "Burkina Faso", Alpha2Code = "BF",
            BoundingBox = new BoundingBox
                {MinLatitude = 9.4104718, MaxLatitude = 15.084, MinLongitude = -5.5132416, MaxLongitude = 2.4089717,}
        },
        new Country
        {
            Name = "Burundi", Alpha2Code = "BI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -4.4693155, MaxLatitude = -2.3096796, MinLongitude = 29.0007401,
                MaxLongitude = 30.8498462,
            }
        },
        new Country
        {
            Name = "Cambodia", Alpha2Code = "KH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 9.4752639, MaxLatitude = 14.6904224, MinLongitude = 102.3338282,
                MaxLongitude = 107.6276788,
            }
        },
        new Country
        {
            Name = "Cameroon", Alpha2Code = "CM",
            BoundingBox = new BoundingBox
                {MinLatitude = 1.6546659, MaxLatitude = 13.083333, MinLongitude = 8.3822176, MaxLongitude = 16.1921476,}
        },
        new Country
        {
            Name = "Canada", Alpha2Code = "CA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.6765556, MaxLatitude = 83.3362128, MinLongitude = -141.00275,
                MaxLongitude = -52.3231981,
            }
        },
        new Country
        {
            Name = "Cape Verde", Alpha2Code = "CV",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 14.8031546, MaxLatitude = 17.2053108, MinLongitude = -25.3609478,
                MaxLongitude = -22.6673416,
            }
        },
        new Country
        {
            Name = "Cayman Islands", Alpha2Code = "KY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 19.0620619, MaxLatitude = 19.9573759, MinLongitude = -81.6313748,
                MaxLongitude = -79.5110954,
            }
        },
        new Country
        {
            Name = "Central African Republic", Alpha2Code = "CF",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 2.2156553, MaxLatitude = 11.001389, MinLongitude = 14.4155426, MaxLongitude = 27.4540764,
            }
        },
        new Country
        {
            Name = "Chad", Alpha2Code = "TD",
            BoundingBox = new BoundingBox
                {MinLatitude = 7.44107, MaxLatitude = 23.4975, MinLongitude = 13.47348, MaxLongitude = 24,}
        },
        new Country
        {
            Name = "Chile", Alpha2Code = "CL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -56.725, MaxLatitude = -17.4983998, MinLongitude = -109.6795789,
                MaxLongitude = -66.0753474,
            }
        },
        new Country
        {
            Name = "China", Alpha2Code = "CN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 8.8383436, MaxLatitude = 53.5608154, MinLongitude = 73.4997347,
                MaxLongitude = 134.7754563,
            }
        },
        new Country
        {
            Name = "Christmas Island", Alpha2Code = "CX",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -10.5698515, MaxLatitude = -10.4123553, MinLongitude = 105.5336422,
                MaxLongitude = 105.7130159,
            }
        },
        new Country
        {
            Name = "Cocos (Keeling) Islands", Alpha2Code = "CC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -12.4055983, MaxLatitude = -11.6213132, MinLongitude = 96.612524,
                MaxLongitude = 97.1357343,
            }
        },
        new Country
        {
            Name = "Colombia", Alpha2Code = "CO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -4.2316872, MaxLatitude = 16.0571269, MinLongitude = -82.1243666,
                MaxLongitude = -66.8511907,
            }
        },
        new Country
        {
            Name = "Comoros", Alpha2Code = "KM",
            BoundingBox = new BoundingBox
                {MinLatitude = -12.621, MaxLatitude = -11.165, MinLongitude = 43.025305, MaxLongitude = 44.7451922,}
        },
        new Country
        {
            Name = "Congo", Alpha2Code = "CG",
            BoundingBox = new BoundingBox
                {MinLatitude = -5.149089, MaxLatitude = 3.713056, MinLongitude = 11.0048205, MaxLongitude = 18.643611,}
        },
        new Country
        {
            Name = "Congo, the Democratic Republic of the", Alpha2Code = "CD",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -13.459035, MaxLatitude = 5.3920026, MinLongitude = 12.039074, MaxLongitude = 31.3056758,
            }
        },
        new Country
        {
            Name = "Cook Islands", Alpha2Code = "CK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -22.15807, MaxLatitude = -8.7168792, MinLongitude = -166.0856468,
                MaxLongitude = -157.1089329,
            }
        },
        new Country
        {
            Name = "Costa Rica", Alpha2Code = "CR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 5.3329698, MaxLatitude = 11.2195684, MinLongitude = -87.2722647,
                MaxLongitude = -82.5060208,
            }
        },
        new Country
        {
            Name = "Côte d'Ivoire", Alpha2Code = "CI",
            BoundingBox = new BoundingBox
                {MinLatitude = 4.1621205, MaxLatitude = 10.740197, MinLongitude = -8.601725, MaxLongitude = -2.493031,}
        },
        new Country
        {
            Name = "Croatia", Alpha2Code = "HR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 42.1765993, MaxLatitude = 46.555029, MinLongitude = 13.2104814, MaxLongitude = 19.4470842,
            }
        },
        new Country
        {
            Name = "Cuba", Alpha2Code = "CU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 19.6275294, MaxLatitude = 23.4816972, MinLongitude = -85.1679702,
                MaxLongitude = -73.9190004,
            }
        },
        new Country
        {
            Name = "Cyprus", Alpha2Code = "CY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 34.4383706, MaxLatitude = 35.913252, MinLongitude = 32.0227581, MaxLongitude = 34.8553182,
            }
        },
        new Country
        {
            Name = "Czech Republic", Alpha2Code = "CZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 48.5518083, MaxLatitude = 51.0557036, MinLongitude = 12.0905901, MaxLongitude = 18.859216,
            }
        },
        new Country
        {
            Name = "Denmark", Alpha2Code = "DK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 54.4516667, MaxLatitude = 57.9524297, MinLongitude = 7.7153255, MaxLongitude = 15.5530641,
            }
        },
        new Country
        {
            Name = "Djibouti", Alpha2Code = "DJ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 10.9149547, MaxLatitude = 12.7923081, MinLongitude = 41.7713139,
                MaxLongitude = 43.6579046,
            }
        },
        new Country
        {
            Name = "Dominica", Alpha2Code = "DM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 15.0074207, MaxLatitude = 15.7872222, MinLongitude = -61.6869184,
                MaxLongitude = -61.0329895,
            }
        },
        new Country
        {
            Name = "Dominican Republic", Alpha2Code = "DO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.2701708, MaxLatitude = 21.303433, MinLongitude = -72.0574706,
                MaxLongitude = -68.1101463,
            }
        },
        new Country
        {
            Name = "Ecuador", Alpha2Code = "EC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -5.0159314, MaxLatitude = 1.8835964, MinLongitude = -92.2072392,
                MaxLongitude = -75.192504,
            }
        },
        new Country
        {
            Name = "Egypt", Alpha2Code = "EG",
            BoundingBox = new BoundingBox
                {MinLatitude = 22, MaxLatitude = 31.8330854, MinLongitude = 24.6499112, MaxLongitude = 37.1153517,}
        },
        new Country
        {
            Name = "El Salvador", Alpha2Code = "SV",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.976046, MaxLatitude = 14.4510488, MinLongitude = -90.1790975,
                MaxLongitude = -87.6351394,
            }
        },
        new Country
        {
            Name = "Equatorial Guinea", Alpha2Code = "GQ",
            BoundingBox = new BoundingBox
                {MinLatitude = -1.6732196, MaxLatitude = 3.989, MinLongitude = 5.4172943, MaxLongitude = 11.3598628,}
        },
        new Country
        {
            Name = "Eritrea", Alpha2Code = "ER",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.3548219, MaxLatitude = 18.0709917, MinLongitude = 36.4333653,
                MaxLongitude = 43.3001714,
            }
        },
        new Country
        {
            Name = "Estonia", Alpha2Code = "EE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 57.5092997, MaxLatitude = 59.9383754, MinLongitude = 21.3826069,
                MaxLongitude = 28.2100175,
            }
        },
        new Country
        {
            Name = "Ethiopia", Alpha2Code = "ET",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 3.397448, MaxLatitude = 14.8940537, MinLongitude = 32.9975838, MaxLongitude = 47.9823797,
            }
        },
        new Country
        {
            Name = "Falkland Islands (Malvinas)", Alpha2Code = "FK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -53.1186766, MaxLatitude = -50.7973007, MinLongitude = -61.7726772,
                MaxLongitude = -57.3662367,
            }
        },
        new Country
        {
            Name = "Faroe Islands", Alpha2Code = "FO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 61.3915553, MaxLatitude = 62.3942991, MinLongitude = -7.6882939,
                MaxLongitude = -6.2565525,
            }
        },
        new Country
        {
            Name = "Fiji", Alpha2Code = "FJ",
            BoundingBox = new BoundingBox
                {MinLatitude = -21.9434274, MaxLatitude = -12.2613866, MinLongitude = 172, MaxLongitude = -178.5,}
        },
        new Country
        {
            Name = "Finland", Alpha2Code = "FI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 59.4541578, MaxLatitude = 70.0922939, MinLongitude = 19.0832098,
                MaxLongitude = 31.5867071,
            }
        },
        new Country
        {
            Name = "France", Alpha2Code = "FR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.2632185, MaxLatitude = 51.268318, MinLongitude = -5.4534286, MaxLongitude = 9.8678344,
            }
        },
        new Country
        {
            Name = "French Guiana", Alpha2Code = "GF",
            BoundingBox = new BoundingBox
                {MinLatitude = 2.112222, MaxLatitude = 5.7507111, MinLongitude = -54.60278, MaxLongitude = -51.6346139,}
        },
        new Country
        {
            Name = "French Polynesia", Alpha2Code = "PF",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -28.0990232, MaxLatitude = -7.6592173, MinLongitude = -154.9360599,
                MaxLongitude = -134.244799,
            }
        },
        new Country
        {
            Name = "French Southern Territories", Alpha2Code = "TF",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -50.2187169, MaxLatitude = -11.3139928, MinLongitude = 39.4138676,
                MaxLongitude = 77.8494974,
            }
        },
        new Country
        {
            Name = "Gabon", Alpha2Code = "GA",
            BoundingBox = new BoundingBox
                {MinLatitude = -4.1012261, MaxLatitude = 2.3182171, MinLongitude = 8.5002246, MaxLongitude = 14.539444,}
        },
        new Country
        {
            Name = "Gambia", Alpha2Code = "GM",
            BoundingBox = new BoundingBox
                {MinLatitude = 13.061, MaxLatitude = 13.8253137, MinLongitude = -17.0288254, MaxLongitude = -13.797778,}
        },
        new Country
        {
            Name = "Georgia", Alpha2Code = "GE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.0552922, MaxLatitude = 43.5864294, MinLongitude = 39.8844803,
                MaxLongitude = 46.7365373,
            }
        },
        new Country
        {
            Name = "Germany", Alpha2Code = "DE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 47.2701114, MaxLatitude = 55.099161, MinLongitude = 5.8663153, MaxLongitude = 15.0419319,
            }
        },
        new Country
        {
            Name = "Ghana", Alpha2Code = "GH",
            BoundingBox = new BoundingBox
                {MinLatitude = 4.5392525, MaxLatitude = 11.1748562, MinLongitude = -3.260786, MaxLongitude = 1.2732942,}
        },
        new Country
        {
            Name = "Gibraltar", Alpha2Code = "GI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 36.100807, MaxLatitude = 36.180807, MinLongitude = -5.3941295, MaxLongitude = -5.3141295,
            }
        },
        new Country
        {
            Name = "Greece", Alpha2Code = "GR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 34.7006096, MaxLatitude = 41.7488862, MinLongitude = 19.2477876,
                MaxLongitude = 29.7296986,
            }
        },
        new Country
        {
            Name = "Greenland", Alpha2Code = "GL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 59.515387, MaxLatitude = 83.875172, MinLongitude = -74.1250416,
                MaxLongitude = -10.0288759,
            }
        },
        new Country
        {
            Name = "Grenada", Alpha2Code = "GD",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 11.786, MaxLatitude = 12.5966532, MinLongitude = -62.0065868, MaxLongitude = -61.1732143,
            }
        },
        new Country
        {
            Name = "Guadeloupe", Alpha2Code = "GP",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 15.8320085, MaxLatitude = 16.5144664, MinLongitude = -61.809764,
                MaxLongitude = -61.0003663,
            }
        },
        new Country
        {
            Name = "Guam", Alpha2Code = "GU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 13.182335, MaxLatitude = 13.706179, MinLongitude = 144.563426, MaxLongitude = 145.009167,
            }
        },
        new Country
        {
            Name = "Guatemala", Alpha2Code = "GT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 13.6345804, MaxLatitude = 17.8165947, MinLongitude = -92.3105242,
                MaxLongitude = -88.1755849,
            }
        },
        new Country
        {
            Name = "Guernsey", Alpha2Code = "GG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 49.4155331, MaxLatitude = 49.5090776, MinLongitude = -2.6751703, MaxLongitude = -2.501814,
            }
        },
        new Country
        {
            Name = "Guinea", Alpha2Code = "GN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 7.1906045, MaxLatitude = 12.67563, MinLongitude = -15.5680508, MaxLongitude = -7.6381993,
            }
        },
        new Country
        {
            Name = "Guinea-Bissau", Alpha2Code = "GW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 10.6514215, MaxLatitude = 12.6862384, MinLongitude = -16.894523,
                MaxLongitude = -13.6348777,
            }
        },
        new Country
        {
            Name = "Guyana", Alpha2Code = "GY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 1.1710017, MaxLatitude = 8.6038842, MinLongitude = -61.414905, MaxLongitude = -56.4689543,
            }
        },
        new Country
        {
            Name = "Haiti", Alpha2Code = "HT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.9099291, MaxLatitude = 20.2181368, MinLongitude = -75.2384618,
                MaxLongitude = -71.6217461,
            }
        },
        new Country
        {
            Name = "Heard Island and McDonald Islands", Alpha2Code = "HM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -53.394741, MaxLatitude = -52.7030677, MinLongitude = 72.2460938,
                MaxLongitude = 74.1988754,
            }
        },
        new Country
        {
            Name = "Holy See (Vatican City State)", Alpha2Code = "VA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.9002044, MaxLatitude = 41.9073912, MinLongitude = 12.4457442,
                MaxLongitude = 12.4583653,
            }
        },
        new Country
        {
            Name = "Honduras", Alpha2Code = "HN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.9808485, MaxLatitude = 17.619526, MinLongitude = -89.3568207,
                MaxLongitude = -82.1729621,
            }
        },
        new Country
        {
            Name = "Hong Kong", Alpha2Code = "HK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 22.1193278, MaxLatitude = 22.4393278, MinLongitude = 114.0028131,
                MaxLongitude = 114.3228131,
            }
        },
        new Country
        {
            Name = "Hungary", Alpha2Code = "HU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 45.737128, MaxLatitude = 48.585257, MinLongitude = 16.1138867, MaxLongitude = 22.8977094,
            }
        },
        new Country
        {
            Name = "Iceland", Alpha2Code = "IS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 63.0859177, MaxLatitude = 67.353, MinLongitude = -25.0135069, MaxLongitude = -12.8046162,
            }
        },
        new Country
        {
            Name = "India", Alpha2Code = "IN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 6.5546079, MaxLatitude = 35.6745457, MinLongitude = 68.1113787, MaxLongitude = 97.395561,
            }
        },
        new Country
        {
            Name = "Indonesia", Alpha2Code = "ID",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -11.2085669, MaxLatitude = 6.2744496, MinLongitude = 94.7717124,
                MaxLongitude = 141.0194444,
            }
        },
        new Country
        {
            Name = "Iran, Islamic Republic of", Alpha2Code = "IR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 24.8465103, MaxLatitude = 39.7816502, MinLongitude = 44.0318908,
                MaxLongitude = 63.3332704,
            }
        },
        new Country
        {
            Name = "Iraq", Alpha2Code = "IQ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 29.0585661, MaxLatitude = 37.380932, MinLongitude = 38.7936719, MaxLongitude = 48.8412702,
            }
        },
        new Country
        {
            Name = "Ireland", Alpha2Code = "IE",
            BoundingBox = new BoundingBox
                {MinLatitude = 51.222, MaxLatitude = 55.636, MinLongitude = -11.0133788, MaxLongitude = -5.6582363,}
        },
        new Country
        {
            Name = "Isle of Man", Alpha2Code = "IM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 54.0539576, MaxLatitude = 54.4178705, MinLongitude = -4.7946845,
                MaxLongitude = -4.3076853,
            }
        },
        new Country
        {
            Name = "Israel", Alpha2Code = "IL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 29.4533796, MaxLatitude = 33.3356317, MinLongitude = 34.2674994,
                MaxLongitude = 35.8950234,
            }
        },
        new Country
        {
            Name = "Italy", Alpha2Code = "IT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 35.2889616, MaxLatitude = 47.0921462, MinLongitude = 6.6272658, MaxLongitude = 18.7844746,
            }
        },
        new Country
        {
            Name = "Jamaica", Alpha2Code = "JM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 16.5899443, MaxLatitude = 18.7256394, MinLongitude = -78.5782366,
                MaxLongitude = -75.7541143,
            }
        },
        new Country
        {
            Name = "Japan", Alpha2Code = "JP",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 20.2145811, MaxLatitude = 45.7112046, MinLongitude = 122.7141754,
                MaxLongitude = 154.205541,
            }
        },
        new Country
        {
            Name = "Jersey", Alpha2Code = "JE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 49.1625179, MaxLatitude = 49.2621288, MinLongitude = -2.254512, MaxLongitude = -2.0104193,
            }
        },
        new Country
        {
            Name = "Jordan", Alpha2Code = "JO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 29.183401, MaxLatitude = 33.3750617, MinLongitude = 34.8844372, MaxLongitude = 39.3012981,
            }
        },
        new Country
        {
            Name = "Kazakhstan", Alpha2Code = "KZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 40.5686476, MaxLatitude = 55.4421701, MinLongitude = 46.4932179,
                MaxLongitude = 87.3156316,
            }
        },
        new Country
        {
            Name = "Kenya", Alpha2Code = "KE",
            BoundingBox = new BoundingBox
                {MinLatitude = -4.8995204, MaxLatitude = 4.62, MinLongitude = 33.9098987, MaxLongitude = 41.899578,}
        },
        new Country
        {
            Name = "Kiribati", Alpha2Code = "KI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -7.0516717, MaxLatitude = 7.9483283, MinLongitude = -179.1645388,
                MaxLongitude = -164.1645388,
            }
        },
        new Country
        {
            Name = "Korea, Democratic People's Republic of", Alpha2Code = "KP",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 37.5867855, MaxLatitude = 43.0089642, MinLongitude = 124.0913902,
                MaxLongitude = 130.924647,
            }
        },
        new Country
        {
            Name = "Korea, Republic of", Alpha2Code = "KR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 32.9104556, MaxLatitude = 38.623477, MinLongitude = 124.354847,
                MaxLongitude = 132.1467806,
            }
        },
        new Country
        {
            Name = "Kuwait", Alpha2Code = "KW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 28.5243622, MaxLatitude = 30.1038082, MinLongitude = 46.5526837,
                MaxLongitude = 49.0046809,
            }
        },
        new Country
        {
            Name = "Kyrgyzstan", Alpha2Code = "KG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 39.1728437, MaxLatitude = 43.2667971, MinLongitude = 69.2649523,
                MaxLongitude = 80.2295793,
            }
        },
        new Country
        {
            Name = "Lao People's Democratic Republic", Alpha2Code = "LA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 13.9096752, MaxLatitude = 22.5086717, MinLongitude = 100.0843247,
                MaxLongitude = 107.6349989,
            }
        },
        new Country
        {
            Name = "Latvia", Alpha2Code = "LV",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 55.6746505, MaxLatitude = 58.0855688, MinLongitude = 20.6715407,
                MaxLongitude = 28.2414904,
            }
        },
        new Country
        {
            Name = "Lebanon", Alpha2Code = "LB",
            BoundingBox = new BoundingBox
                {MinLatitude = 33.0479858, MaxLatitude = 34.6923543, MinLongitude = 34.8825667, MaxLongitude = 36.625,}
        },
        new Country
        {
            Name = "Lesotho", Alpha2Code = "LS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -30.6772773, MaxLatitude = -28.570615, MinLongitude = 27.0114632,
                MaxLongitude = 29.4557099,
            }
        },
        new Country
        {
            Name = "Liberia", Alpha2Code = "LR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 4.1555907, MaxLatitude = 8.5519861, MinLongitude = -11.6080764, MaxLongitude = -7.367323,
            }
        },
        new Country
        {
            Name = "Libyan Arab Jamahiriya", Alpha2Code = "LY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 19.5008138, MaxLatitude = 33.3545898, MinLongitude = 9.391081, MaxLongitude = 25.3770629,
            }
        },
        new Country
        {
            Name = "Liechtenstein", Alpha2Code = "LI",
            BoundingBox = new BoundingBox
                {MinLatitude = 47.0484291, MaxLatitude = 47.270581, MinLongitude = 9.4716736, MaxLongitude = 9.6357143,}
        },
        new Country
        {
            Name = "Lithuania", Alpha2Code = "LT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 53.8967893, MaxLatitude = 56.4504213, MinLongitude = 20.653783, MaxLongitude = 26.8355198,
            }
        },
        new Country
        {
            Name = "Luxembourg", Alpha2Code = "LU",
            BoundingBox = new BoundingBox
                {MinLatitude = 49.4969821, MaxLatitude = 50.430377, MinLongitude = 4.9684415, MaxLongitude = 6.0344254,}
        },
        new Country
        {
            Name = "Macao", Alpha2Code = "MO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 22.0766667, MaxLatitude = 22.2170361, MinLongitude = 113.5281666,
                MaxLongitude = 113.6301389,
            }
        },
        new Country
        {
            Name = "Macedonia, the former Yugoslav Republic of", Alpha2Code = "MK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 40.8536596, MaxLatitude = 42.3735359, MinLongitude = 20.4529023, MaxLongitude = 23.034051,
            }
        },
        new Country
        {
            Name = "Madagascar", Alpha2Code = "MG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -25.6071002, MaxLatitude = -11.9519693, MinLongitude = 43.2202072,
                MaxLongitude = 50.4862553,
            }
        },
        new Country
        {
            Name = "Malawi", Alpha2Code = "MW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -17.1296031, MaxLatitude = -9.3683261, MinLongitude = 32.6703616,
                MaxLongitude = 35.9185731,
            }
        },
        new Country
        {
            Name = "Malaysia", Alpha2Code = "MY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -5.1076241, MaxLatitude = 9.8923759, MinLongitude = 105.3471939,
                MaxLongitude = 120.3471939,
            }
        },
        new Country
        {
            Name = "Maldives", Alpha2Code = "MV",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -0.9074935, MaxLatitude = 7.3106246, MinLongitude = 72.3554187, MaxLongitude = 73.9700962,
            }
        },
        new Country
        {
            Name = "Mali", Alpha2Code = "ML",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 10.147811, MaxLatitude = 25.001084, MinLongitude = -12.2402835, MaxLongitude = 4.2673828,
            }
        },
        new Country
        {
            Name = "Malta", Alpha2Code = "MT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 35.6029696, MaxLatitude = 36.2852706, MinLongitude = 13.9324226,
                MaxLongitude = 14.8267966,
            }
        },
        new Country
        {
            Name = "Marshall Islands", Alpha2Code = "MH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -0.5481258, MaxLatitude = 14.4518742, MinLongitude = 163.4985095,
                MaxLongitude = 178.4985095,
            }
        },
        new Country
        {
            Name = "Martinique", Alpha2Code = "MQ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 14.3948596, MaxLatitude = 14.8787029, MinLongitude = -61.2290815,
                MaxLongitude = -60.8095833,
            }
        },
        new Country
        {
            Name = "Mauritania", Alpha2Code = "MR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 14.7209909, MaxLatitude = 27.314942, MinLongitude = -17.068081, MaxLongitude = -4.8333344,
            }
        },
        new Country
        {
            Name = "Mauritius", Alpha2Code = "MU",
            BoundingBox = new BoundingBox
                {MinLatitude = -20.725, MaxLatitude = -10.138, MinLongitude = 56.3825151, MaxLongitude = 63.7151319,}
        },
        new Country
        {
            Name = "Mayotte", Alpha2Code = "YT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -13.0210119, MaxLatitude = -12.6365902, MinLongitude = 45.0183298,
                MaxLongitude = 45.2999917,
            }
        },
        new Country
        {
            Name = "Mexico", Alpha2Code = "MX",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 14.3886243, MaxLatitude = 32.7186553, MinLongitude = -118.59919,
                MaxLongitude = -86.493266,
            }
        },
        new Country
        {
            Name = "Micronesia, Federated States of", Alpha2Code = "FM",
            BoundingBox = new BoundingBox
                {MinLatitude = 0.827, MaxLatitude = 10.291, MinLongitude = 137.2234512, MaxLongitude = 163.2364054,}
        },
        new Country
        {
            Name = "Moldova, Republic of", Alpha2Code = "MD",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 45.4674139, MaxLatitude = 48.4918695, MinLongitude = 26.6162189,
                MaxLongitude = 30.1636756,
            }
        },
        new Country
        {
            Name = "Monaco", Alpha2Code = "MC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 43.7247599, MaxLatitude = 43.7519311, MinLongitude = 7.4090279, MaxLongitude = 7.4398704,
            }
        },
        new Country
        {
            Name = "Mongolia", Alpha2Code = "MN",
            BoundingBox = new BoundingBox
                {MinLatitude = 41.5800276, MaxLatitude = 52.1496, MinLongitude = 87.73762, MaxLongitude = 119.931949,}
        },
        new Country
        {
            Name = "Montenegro", Alpha2Code = "ME",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 41.7495999, MaxLatitude = 43.5585061, MinLongitude = 18.4195781,
                MaxLongitude = 20.3561641,
            }
        },
        new Country
        {
            Name = "Montserrat", Alpha2Code = "MS",
            BoundingBox = new BoundingBox
                {MinLatitude = 16.475, MaxLatitude = 17.0152978, MinLongitude = -62.450667, MaxLongitude = -61.9353818,}
        },
        new Country
        {
            Name = "Morocco", Alpha2Code = "MA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 21.3365321, MaxLatitude = 36.0505269, MinLongitude = -17.2551456,
                MaxLongitude = -0.998429,
            }
        },
        new Country
        {
            Name = "Mozambique", Alpha2Code = "MZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -26.9209427, MaxLatitude = -10.3252149, MinLongitude = 30.2138197,
                MaxLongitude = 41.0545908,
            }
        },
        new Country
        {
            Name = "Myanmar", Alpha2Code = "MM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 9.4399432, MaxLatitude = 28.547835, MinLongitude = 92.1719423, MaxLongitude = 101.1700796,
            }
        },
        new Country
        {
            Name = "Namibia", Alpha2Code = "NA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -28.96945, MaxLatitude = -16.9634855, MinLongitude = 11.5280384,
                MaxLongitude = 25.2617671,
            }
        },
        new Country
        {
            Name = "Nauru", Alpha2Code = "NR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -0.5541334, MaxLatitude = -0.5025906, MinLongitude = 166.9091794,
                MaxLongitude = 166.9589235,
            }
        },
        new Country
        {
            Name = "Nepal", Alpha2Code = "NP",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 26.3477581, MaxLatitude = 30.446945, MinLongitude = 80.0586226, MaxLongitude = 88.2015257,
            }
        },
        new Country
        {
            Name = "Netherlands", Alpha2Code = "NL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 50.7295671, MaxLatitude = 53.7253321, MinLongitude = 1.9193492, MaxLongitude = 7.2274985,
            }
        },
        new Country
        {
            Name = "Netherlands Antilles", Alpha2Code = "AN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.1544542, MaxLatitude = 12.1547472, MinLongitude = -68.940593,
                MaxLongitude = -68.9403518,
            }
        },
        new Country
        {
            Name = "New Caledonia", Alpha2Code = "NC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -23.2217509, MaxLatitude = -17.6868616, MinLongitude = 162.6034343,
                MaxLongitude = 167.8109827,
            }
        },
        new Country
        {
            Name = "New Zealand", Alpha2Code = "NZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -52.8213687, MaxLatitude = -29.0303303, MinLongitude = -179.059153,
                MaxLongitude = 179.3643594,
            }
        },
        new Country
        {
            Name = "Nicaragua", Alpha2Code = "NI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 10.7076565, MaxLatitude = 15.0331183, MinLongitude = -87.901532,
                MaxLongitude = -82.6227023,
            }
        },
        new Country
        {
            Name = "Niger", Alpha2Code = "NE",
            BoundingBox = new BoundingBox
                {MinLatitude = 11.693756, MaxLatitude = 23.517178, MinLongitude = 0.1689653, MaxLongitude = 15.996667,}
        },
        new Country
        {
            Name = "Nigeria", Alpha2Code = "NG",
            BoundingBox = new BoundingBox
                {MinLatitude = 4.0690959, MaxLatitude = 13.885645, MinLongitude = 2.676932, MaxLongitude = 14.678014,}
        },
        new Country
        {
            Name = "Niue", Alpha2Code = "NU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -19.3548665, MaxLatitude = -18.7534559, MinLongitude = -170.1595029,
                MaxLongitude = -169.5647229,
            }
        },
        new Country
        {
            Name = "Norfolk Island", Alpha2Code = "NF",
            BoundingBox = new BoundingBox
                {MinLatitude = -29.333, MaxLatitude = -28.796, MinLongitude = 167.6873878, MaxLongitude = 168.2249543,}
        },
        new Country
        {
            Name = "Northern Mariana Islands", Alpha2Code = "MP",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 14.036565, MaxLatitude = 20.616556, MinLongitude = 144.813338, MaxLongitude = 146.154418,
            }
        },
        new Country
        {
            Name = "Norway", Alpha2Code = "NO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 57.7590052, MaxLatitude = 71.3848787, MinLongitude = 4.0875274, MaxLongitude = 31.7614911,
            }
        },
        new Country
        {
            Name = "Oman", Alpha2Code = "OM",
            BoundingBox = new BoundingBox
                {MinLatitude = 16.4649608, MaxLatitude = 26.7026737, MinLongitude = 52, MaxLongitude = 60.054577,}
        },
        new Country
        {
            Name = "Pakistan", Alpha2Code = "PK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 23.5393916, MaxLatitude = 37.084107, MinLongitude = 60.872855, MaxLongitude = 77.1203914,
            }
        },
        new Country
        {
            Name = "Palau", Alpha2Code = "PW",
            BoundingBox = new BoundingBox
                {MinLatitude = 2.748, MaxLatitude = 8.222, MinLongitude = 131.0685462, MaxLongitude = 134.7714735,}
        },
        new Country
        {
            Name = "Palestinian Territory, Occupied", Alpha2Code = "PS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 31.2201289, MaxLatitude = 32.5521479, MinLongitude = 34.0689732,
                MaxLongitude = 35.5739235,
            }
        },
        new Country
        {
            Name = "Panama", Alpha2Code = "PA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 7.0338679, MaxLatitude = 9.8701757, MinLongitude = -83.0517245,
                MaxLongitude = -77.1393779,
            }
        },
        new Country
        {
            Name = "Papua New Guinea", Alpha2Code = "PG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -13.1816069, MaxLatitude = 1.8183931, MinLongitude = 136.7489081,
                MaxLongitude = 151.7489081,
            }
        },
        new Country
        {
            Name = "Paraguay", Alpha2Code = "PY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -27.6063935, MaxLatitude = -19.2876472, MinLongitude = -62.6442036,
                MaxLongitude = -54.258,
            }
        },
        new Country
        {
            Name = "Peru", Alpha2Code = "PE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -20.1984472, MaxLatitude = -0.0392818, MinLongitude = -84.6356535,
                MaxLongitude = -68.6519906,
            }
        },
        new Country
        {
            Name = "Philippines", Alpha2Code = "PH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 4.2158064, MaxLatitude = 21.3217806, MinLongitude = 114.0952145,
                MaxLongitude = 126.8072562,
            }
        },
        new Country
        {
            Name = "Pitcairn", Alpha2Code = "PN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -25.1306736, MaxLatitude = -23.8655769, MinLongitude = -130.8049862,
                MaxLongitude = -124.717534,
            }
        },
        new Country
        {
            Name = "Poland", Alpha2Code = "PL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 49.0020468, MaxLatitude = 55.0336963, MinLongitude = 14.1229707, MaxLongitude = 24.145783,
            }
        },
        new Country
        {
            Name = "Portugal", Alpha2Code = "PT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 29.8288021, MaxLatitude = 42.1543112, MinLongitude = -31.5575303,
                MaxLongitude = -6.1891593,
            }
        },
        new Country
        {
            Name = "Puerto Rico", Alpha2Code = "PR",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.9268695, MaxLatitude = 18.5159789, MinLongitude = -67.271492,
                MaxLongitude = -65.5897525,
            }
        },
        new Country
        {
            Name = "Qatar", Alpha2Code = "QA",
            BoundingBox = new BoundingBox
                {MinLatitude = 24.4707534, MaxLatitude = 26.3830212, MinLongitude = 50.5675, MaxLongitude = 52.638011,}
        },
        new Country
        {
            Name = "Réunion", Alpha2Code = "RE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -21.3897308, MaxLatitude = -20.8717136, MinLongitude = 55.2164268,
                MaxLongitude = 55.8366924,
            }
        },
        new Country
        {
            Name = "Romania", Alpha2Code = "RO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 43.618682, MaxLatitude = 48.2653964, MinLongitude = 20.2619773, MaxLongitude = 30.0454257,
            }
        },
        new Country
        {
            Name = "Russian Federation", Alpha2Code = "RU",
            BoundingBox = new BoundingBox
                {MinLatitude = 41.1850968, MaxLatitude = 82.0586232, MinLongitude = 19.6389, MaxLongitude = 180,}
        },
        new Country
        {
            Name = "Rwanda", Alpha2Code = "RW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -2.8389804, MaxLatitude = -1.0474083, MinLongitude = 28.8617546,
                MaxLongitude = 30.8990738,
            }
        },
        new Country
        {
            Name = "Saint Barthélemy", Alpha2Code = "BL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.670931, MaxLatitude = 18.1375569, MinLongitude = -63.06639, MaxLongitude = -62.5844019,
            }
        },
        new Country
        {
            Name = "Saint Helena, Ascension and Tristan da Cunha", Alpha2Code = "SH",
            BoundingBox = new BoundingBox
                {MinLatitude = -16.23, MaxLatitude = -15.704, MinLongitude = -5.9973424, MaxLongitude = -5.4234153,}
        },
        new Country
        {
            Name = "Saint Kitts and Nevis", Alpha2Code = "KN",
            BoundingBox = new BoundingBox
                {MinLatitude = 16.895, MaxLatitude = 17.6158146, MinLongitude = -63.051129, MaxLongitude = -62.3303519,}
        },
        new Country
        {
            Name = "Saint Lucia", Alpha2Code = "LC",
            BoundingBox = new BoundingBox
                {MinLatitude = 13.508, MaxLatitude = 14.2725, MinLongitude = -61.2853867, MaxLongitude = -60.6669363,}
        },
        new Country
        {
            Name = "Saint Martin (French part)", Alpha2Code = "MF",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.8963535, MaxLatitude = 18.1902778, MinLongitude = -63.3605643,
                MaxLongitude = -62.7644063,
            }
        },
        new Country
        {
            Name = "Saint Pierre and Miquelon", Alpha2Code = "PM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 46.5507173, MaxLatitude = 47.365, MinLongitude = -56.6972961, MaxLongitude = -55.9033333,
            }
        },
        new Country
        {
            Name = "Saint Vincent and the Grenadines", Alpha2Code = "VC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.5166548, MaxLatitude = 13.583, MinLongitude = -61.6657471, MaxLongitude = -60.9094146,
            }
        },
        new Country
        {
            Name = "Samoa", Alpha2Code = "WS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -14.2770916, MaxLatitude = -13.2381892, MinLongitude = -173.0091864,
                MaxLongitude = -171.1929229,
            }
        },
        new Country
        {
            Name = "San Marino", Alpha2Code = "SM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 43.8937002, MaxLatitude = 43.992093, MinLongitude = 12.4033246, MaxLongitude = 12.5160665,
            }
        },
        new Country
        {
            Name = "Sao Tome and Principe", Alpha2Code = "ST",
            BoundingBox = new BoundingBox
                {MinLatitude = -0.2135137, MaxLatitude = 1.9257601, MinLongitude = 6.260642, MaxLongitude = 7.6704783,}
        },
        new Country
        {
            Name = "Saudi Arabia", Alpha2Code = "SA",
            BoundingBox = new BoundingBox
                {MinLatitude = 16.29, MaxLatitude = 32.1543377, MinLongitude = 34.4571718, MaxLongitude = 55.6666851,}
        },
        new Country
        {
            Name = "Senegal", Alpha2Code = "SN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 12.2372838, MaxLatitude = 16.6919712, MinLongitude = -17.7862419,
                MaxLongitude = -11.3458996,
            }
        },
        new Country
        {
            Name = "Serbia", Alpha2Code = "RS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 42.2322435, MaxLatitude = 46.1900524, MinLongitude = 18.8142875, MaxLongitude = 23.006309,
            }
        },
        new Country
        {
            Name = "Seychelles", Alpha2Code = "SC",
            BoundingBox = new BoundingBox
                {MinLatitude = -10.4649258, MaxLatitude = -3.512, MinLongitude = 45.9988759, MaxLongitude = 56.4979396,}
        },
        new Country
        {
            Name = "Sierra Leone", Alpha2Code = "SL",
            BoundingBox = new BoundingBox
                {MinLatitude = 6.755, MaxLatitude = 9.999973, MinLongitude = -13.5003389, MaxLongitude = -10.271683,}
        },
        new Country
        {
            Name = "Singapore", Alpha2Code = "SG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 1.1304753, MaxLatitude = 1.4504753, MinLongitude = 103.6920359,
                MaxLongitude = 104.0120359,
            }
        },
        new Country
        {
            Name = "Slovakia", Alpha2Code = "SK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 47.7314286, MaxLatitude = 49.6138162, MinLongitude = 16.8331891, MaxLongitude = 22.56571,
            }
        },
        new Country
        {
            Name = "Slovenia", Alpha2Code = "SI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 45.4214242, MaxLatitude = 46.8766816, MinLongitude = 13.3754696,
                MaxLongitude = 16.5967702,
            }
        },
        new Country
        {
            Name = "Solomon Islands", Alpha2Code = "SB",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -13.2424298, MaxLatitude = -4.81085, MinLongitude = 155.3190556,
                MaxLongitude = 170.3964667,
            }
        },
        new Country
        {
            Name = "Somalia", Alpha2Code = "SO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -1.8031969, MaxLatitude = 12.1889121, MinLongitude = 40.98918, MaxLongitude = 51.6177696,
            }
        },
        new Country
        {
            Name = "South Africa", Alpha2Code = "ZA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -47.1788335, MaxLatitude = -22.1250301, MinLongitude = 16.3335213,
                MaxLongitude = 38.2898954,
            }
        },
        new Country
        {
            Name = "South Georgia and the South Sandwich Islands", Alpha2Code = "GS",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -59.684, MaxLatitude = -53.3500755, MinLongitude = -42.354739, MaxLongitude = -25.8468303,
            }
        },
        new Country
        {
            Name = "Spain", Alpha2Code = "ES",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 27.4335426, MaxLatitude = 43.9933088, MinLongitude = -18.3936845,
                MaxLongitude = 4.5918885,
            }
        },
        new Country
        {
            Name = "Sri Lanka", Alpha2Code = "LK",
            BoundingBox = new BoundingBox
                {MinLatitude = 5.719, MaxLatitude = 10.035, MinLongitude = 79.3959205, MaxLongitude = 82.0810141,}
        },
        new Country
        {
            Name = "Sudan", Alpha2Code = "SD",
            BoundingBox = new BoundingBox
                {MinLatitude = 8.685278, MaxLatitude = 22.224918, MinLongitude = 21.8145046, MaxLongitude = 39.0576252,}
        },
        new Country
        {
            Name = "Suriname", Alpha2Code = "SR",
            BoundingBox = new BoundingBox
                {MinLatitude = 1.8312802, MaxLatitude = 6.225, MinLongitude = -58.070833, MaxLongitude = -53.8433358,}
        },
        new Country
        {
            Name = "Svalbard and Jan Mayen", Alpha2Code = "SJ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 70.6260825, MaxLatitude = 81.028076, MinLongitude = -9.6848146, MaxLongitude = 34.6891253,
            }
        },
        new Country
        {
            Name = "Swaziland", Alpha2Code = "SZ",
            BoundingBox = new BoundingBox
                {MinLatitude = -27.3175201, MaxLatitude = -25.71876, MinLongitude = 30.7908, MaxLongitude = 32.1349923,}
        },
        new Country
        {
            Name = "Sweden", Alpha2Code = "SE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 55.1331192, MaxLatitude = 69.0599699, MinLongitude = 10.5930952,
                MaxLongitude = 24.1776819,
            }
        },
        new Country
        {
            Name = "Switzerland", Alpha2Code = "CH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 45.817995, MaxLatitude = 47.8084648, MinLongitude = 5.9559113, MaxLongitude = 10.4922941,
            }
        },
        new Country
        {
            Name = "Syrian Arab Republic", Alpha2Code = "SY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 32.311354, MaxLatitude = 37.3184589, MinLongitude = 35.4714427, MaxLongitude = 42.3745687,
            }
        },
        new Country
        {
            Name = "Taiwan, Province of China", Alpha2Code = "TW",
            BoundingBox = new BoundingBox
                {MinLatitude = 10.374269, MaxLatitude = 26.4372222, MinLongitude = 114.3599058, MaxLongitude = 122.297,}
        },
        new Country
        {
            Name = "Tajikistan", Alpha2Code = "TJ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 36.6711153, MaxLatitude = 41.0450935, MinLongitude = 67.3332775,
                MaxLongitude = 75.1539563,
            }
        },
        new Country
        {
            Name = "Tanzania, United Republic of", Alpha2Code = "TZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -11.761254, MaxLatitude = -0.9854812, MinLongitude = 29.3269773,
                MaxLongitude = 40.6584071,
            }
        },
        new Country
        {
            Name = "Thailand", Alpha2Code = "TH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 5.612851, MaxLatitude = 20.4648337, MinLongitude = 97.3438072, MaxLongitude = 105.636812,
            }
        },
        new Country
        {
            Name = "Timor-Leste", Alpha2Code = "TL",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -9.5642775, MaxLatitude = -8.0895459, MinLongitude = 124.0415703,
                MaxLongitude = 127.5335392,
            }
        },
        new Country
        {
            Name = "Togo", Alpha2Code = "TG",
            BoundingBox = new BoundingBox
                {MinLatitude = 5.926547, MaxLatitude = 11.1395102, MinLongitude = -0.1439746, MaxLongitude = 1.8087605,}
        },
        new Country
        {
            Name = "Tokelau", Alpha2Code = "TK",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -9.6442499, MaxLatitude = -8.3328631, MinLongitude = -172.7213673,
                MaxLongitude = -170.9797586,
            }
        },
        new Country
        {
            Name = "Tonga", Alpha2Code = "TO",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -24.1034499, MaxLatitude = -15.3655722, MinLongitude = -179.3866055,
                MaxLongitude = -173.5295458,
            }
        },
        new Country
        {
            Name = "Trinidad and Tobago", Alpha2Code = "TT",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 9.8732106, MaxLatitude = 11.5628372, MinLongitude = -62.083056,
                MaxLongitude = -60.2895848,
            }
        },
        new Country
        {
            Name = "Tunisia", Alpha2Code = "TN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 30.230236, MaxLatitude = 37.7612052, MinLongitude = 7.5219807, MaxLongitude = 11.8801133,
            }
        },
        new Country
        {
            Name = "Turkey", Alpha2Code = "TR",
            BoundingBox = new BoundingBox
                {MinLatitude = 35.8076804, MaxLatitude = 42.297, MinLongitude = 25.6212891, MaxLongitude = 44.8176638,}
        },
        new Country
        {
            Name = "Turkmenistan", Alpha2Code = "TM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 35.129093, MaxLatitude = 42.7975571, MinLongitude = 52.335076, MaxLongitude = 66.6895177,
            }
        },
        new Country
        {
            Name = "Turks and Caicos Islands", Alpha2Code = "TC",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 20.9553418, MaxLatitude = 22.1630989, MinLongitude = -72.6799046,
                MaxLongitude = -70.8643591,
            }
        },
        new Country
        {
            Name = "Tuvalu", Alpha2Code = "TV",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -9.9939389, MaxLatitude = -5.4369611, MinLongitude = 175.1590468,
                MaxLongitude = 178.7344938,
            }
        },
        new Country
        {
            Name = "Uganda", Alpha2Code = "UG",
            BoundingBox = new BoundingBox
                {MinLatitude = -1.4823179, MaxLatitude = 4.2340766, MinLongitude = 29.573433, MaxLongitude = 35.000308,}
        },
        new Country
        {
            Name = "Ukraine", Alpha2Code = "UA",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 44.184598, MaxLatitude = 52.3791473, MinLongitude = 22.137059, MaxLongitude = 40.2275801,
            }
        },
        new Country
        {
            Name = "United Arab Emirates", Alpha2Code = "AE",
            BoundingBox = new BoundingBox
                {MinLatitude = 22.6444, MaxLatitude = 26.2822, MinLongitude = 51.498, MaxLongitude = 56.3834,}
        },
        new Country
        {
            Name = "United Kingdom", Alpha2Code = "GB",
            BoundingBox = new BoundingBox
                {MinLatitude = 49.674, MaxLatitude = 61.061, MinLongitude = -14.015517, MaxLongitude = 2.0919117,}
        },
        new Country
        {
            Name = "United States", Alpha2Code = "US",
            BoundingBox = new BoundingBox
                {MinLatitude = 24.9493, MaxLatitude = 49.5904, MinLongitude = -125.0011, MaxLongitude = -66.9326,}
        },
        new Country
        {
            Name = "United States Minor Outlying Islands", Alpha2Code = "UM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 6.1779744, MaxLatitude = 6.6514388, MinLongitude = -162.6816297,
                MaxLongitude = -162.1339885,
            }
        },
        new Country
        {
            Name = "Uruguay", Alpha2Code = "UY",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -35.7824481, MaxLatitude = -30.0853962, MinLongitude = -58.4948438,
                MaxLongitude = -53.0755833,
            }
        },
        new Country
        {
            Name = "Uzbekistan", Alpha2Code = "UZ",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 37.1821164, MaxLatitude = 45.590118, MinLongitude = 55.9977865, MaxLongitude = 73.1397362,
            }
        },
        new Country
        {
            Name = "Vanuatu", Alpha2Code = "VU",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -20.4627425, MaxLatitude = -12.8713777, MinLongitude = 166.3355255,
                MaxLongitude = 170.449982,
            }
        },
        new Country
        {
            Name = "Venezuela, Bolivarian Republic of", Alpha2Code = "VE",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 0.647529, MaxLatitude = 15.9158431, MinLongitude = -73.3529632,
                MaxLongitude = -59.5427079,
            }
        },
        new Country
        {
            Name = "Viet Nam", Alpha2Code = "VN",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 8.1790665, MaxLatitude = 23.393395, MinLongitude = 102.14441, MaxLongitude = 114.3337595,
            }
        },
        new Country
        {
            Name = "Virgin Islands, British", Alpha2Code = "VG",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.623468, MaxLatitude = 18.464984, MinLongitude = -65.159094, MaxLongitude = -64.512674,
            }
        },
        new Country
        {
            Name = "Virgin Islands, U.S.", Alpha2Code = "VI",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 17.623468, MaxLatitude = 18.464984, MinLongitude = -65.159094, MaxLongitude = -64.512674,
            }
        },
        new Country
        {
            Name = "Wallis and Futuna", Alpha2Code = "WF",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -14.5630748, MaxLatitude = -12.9827961, MinLongitude = -178.3873749,
                MaxLongitude = -175.9190391,
            }
        },
        new Country
        {
            Name = "Western Sahara", Alpha2Code = "EH",
            BoundingBox = new BoundingBox
            {
                MinLatitude = 20.556883, MaxLatitude = 27.6666834, MinLongitude = -17.3494721, MaxLongitude = -8.666389,
            }
        },
        new Country
        {
            Name = "Yemen", Alpha2Code = "YE",
            BoundingBox = new BoundingBox
                {MinLatitude = 11.9084802, MaxLatitude = 19, MinLongitude = 41.60825, MaxLongitude = 54.7389375,}
        },
        new Country
        {
            Name = "Zambia", Alpha2Code = "ZM",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -18.0765945, MaxLatitude = -8.2712822, MinLongitude = 21.9993509,
                MaxLongitude = 33.701111,
            }
        },
        new Country
        {
            Name = "Zimbabwe", Alpha2Code = "ZW",
            BoundingBox = new BoundingBox
            {
                MinLatitude = -22.4241096, MaxLatitude = -15.6097033, MinLongitude = 25.2373, MaxLongitude = 33.0683413,
            }
        }
    };
}