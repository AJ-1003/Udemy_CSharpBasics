using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class CalculateDemeritPoints
    {
        public string DemeritPoints(int speedLimit, int carSpeed)
        {
            string licenseStatus;
            if (carSpeed < speedLimit)
            {
                licenseStatus = "Your license is still OK.";
            }
            else
            {
                var speedLimitExceededBy = carSpeed - speedLimit;
                var points = (double) speedLimitExceededBy / 5;
                var demeritPoints = Math.Ceiling(points);
                if (demeritPoints >= 12)
                {
                    licenseStatus = $"License Suspended due to your {demeritPoints} demerit points. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
                else
                {
                    licenseStatus = $"You have {demeritPoints} demerit points against your license. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
            }

            return licenseStatus;
        }

        public string DemeritPoints(float speedLimit, float carSpeed)
        {
            string licenseStatus;
            if (carSpeed < speedLimit)
            {
                licenseStatus = "Your license is still OK.";
            }
            else
            {
                var speedLimitExceededBy = carSpeed - speedLimit;
                var points = (double)speedLimitExceededBy / 5;
                var demeritPoints = Math.Ceiling(points);
                if (demeritPoints >= 12)
                {
                    licenseStatus = $"License Suspended due to your {demeritPoints} demerit points. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
                else
                {
                    licenseStatus = $"You have {demeritPoints} demerit points against your license. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
            }

            return licenseStatus;
        }

        public string DemeritPoints(double speedLimit, double carSpeed)
        {
            string licenseStatus;
            if (carSpeed < speedLimit)
            {
                licenseStatus = "Your license is still OK.";
            }
            else
            {
                var speedLimitExceededBy = carSpeed - speedLimit;
                var points = (double)speedLimitExceededBy / 5;
                var demeritPoints = Math.Ceiling(points);
                if (demeritPoints >= 12)
                {
                    licenseStatus = $"License Suspended due to your {demeritPoints} demerit points. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
                else
                {
                    licenseStatus = $"You have {demeritPoints} demerit points against your license. You exceeded the speed limit by {speedLimitExceededBy}.";
                }
            }

            return licenseStatus;
        }
    }
}
